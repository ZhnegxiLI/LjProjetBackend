using LjData.JpushModel;
using LjData.Models;
using LjData.Utils;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
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


    }
}
