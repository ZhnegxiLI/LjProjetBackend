using LjData.JpushModel;
using LjData.Models;
using LjData.Utils;
using LjDataAccess.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LjDataAccess.Repositories
{
    public class SendMobilePushRepository: ISendMobilePushRepository
    {
        private NotificationEvent _notificationEvent;
        private IUtils utils;
        private readonly ERPDATA2Context context;
        public readonly IConfiguration Configuration;

        public SendMobilePushRepository(NotificationEvent notificationEvent, ERPDATA2Context context, IConfiguration configuration)
        {
            _notificationEvent = notificationEvent;
            this.context = context;
            this.utils = new Utils();
            Configuration = configuration;
        }

        public async Task sendNotificationRequestAsync()
        {

            JPushClient client = new JPushClient(Configuration["JpushConfig:appKey"], Configuration["JpushConfig:MasterSecret"]);

            var result = from message in context.MobilePushMessage
                         where message.IsSend == false
                         select message;

            var messageList = result.ToList<MobilePushMessage>();

            foreach (MobilePushMessage message in messageList)
            {
                List<string> EmailList = new List<string>();
                /* Get email to send users */
                if (message.UserId != null)
                {
                    var userEmail = context.Personel.Where(p => p.EmpnPsl == message.UserId && p.EmailPsl!=null).Select(p => p.EmailPsl).FirstOrDefault();
                    if (userEmail!=null)
                    {
                        EmailList.Add(userEmail);
                    }
                }
                if (message.UserGroup !=null)
                {
                    var userGroupEmail = (from p in context.MobilePermission
                                          join up in context.MobileUserPermission on p.Id equals up.PermissionId
                                          join u in context.Personel on up.UserId equals u.EmpnPsl
                                          where p.Code == message.UserGroup && u.EmailPsl != null
                                          select u.EmailPsl).ToList();

                    if (userGroupEmail.Count() > 0)
                    {
                        EmailList.Concat(userGroupEmail);
                    }
                }
                if (EmailList.Count()>0)
                {
                    foreach (var item in EmailList)
                    {
                        SendEmail(item, message.Title, message.Body, null);
                    }
                }
               
                PushPayload pushPayload = creatPushMessage(message);
                var test = client.SendPush(pushPayload);

                message.IsSend = true;
                context.MobilePushMessage.Update(message);
            }
            await context.SaveChangesAsync();
            return;
        }

        public PushPayload creatPushMessage(MobilePushMessage message)
        {
    
            List<String> tags = new List<string>();
            if(message.UserId != null)
            {
                tags.Add(message.UserId);
            }
            if(message.UserGroup != null)
            {
                tags.Add(message.UserGroup);
            }
            
            PushPayload pushPayload = new PushPayload()
            {
                Platform = new List<string> { "android","ios" },
                Audience = new Audience { Tag = tags },
                Notification = new Notification
                {
                    Alert = message.Body,
                    Android = new Android
                    {
                        Title = message.Title
                    }
                }
            };

            return pushPayload;
        }

           public string SendEmail(string ToEmail,string Subjet, string Message, string AttachmentPath)
            {

            try
            {
                // todo add infor into appconfig 
                MimeMessage message = new MimeMessage();

                MailboxAddress from = new MailboxAddress("丽锦纺织",
                Configuration["Mailkit:EmailAccount"]);
                message.From.Add(from);

                MailboxAddress to = new MailboxAddress(ToEmail,
                ToEmail);
                message.To.Add(to);

                message.Subject = Subjet;
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = Message;
               
                if (AttachmentPath != null)
                {
                    bodyBuilder.Attachments.Add(AttachmentPath);
                }

                message.Body = bodyBuilder.ToMessageBody();


                SmtpClient client = new SmtpClient();
                client.Connect(Configuration["Mailkit:EmailHost"], int.Parse(Configuration["Mailkit:EmailPort"]), true);
                client.Authenticate(Configuration["Mailkit:EmailAccount"], Configuration["Mailkit:EmailPassword"]);

                client.Send(message);
                client.Disconnect(true);
                client.Dispose();
            
                return "Email Sent Successfully!"; //todo change to code 
            }
            catch (System.Exception e)
            {
                return e.Message; // todo change to code 
            }
        }



    }
}
