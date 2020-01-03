using LjData.JpushModel;
using LjData.Utils;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LjDataAccess.Repositories
{
    public class SqlListenerRepository : ISqlListenerRepository
    {
        private NotificationEvent _notificationEvent;
        private IUtils utils;
        private readonly ERPDATA2Context context;
        public SqlListenerRepository(NotificationEvent notificationEvent, ERPDATA2Context context)
        {
            _notificationEvent = notificationEvent;
            this.context = context;
            this.utils = new Utils();
        }

        public void sendNotificationRequest(string appkey, string masterSecret ,string userId, string orderId, string oldStatusId, string newStatusId, string updateBy, string orderType)
        {
            JPushClient client = new JPushClient(appkey, masterSecret);
            string orderTypeDescript = utils.GetCommandTypeLabelById(orderType);
            string updateByName = context.Personel.Where(p=>p.EmpnPsl == updateBy).Select(p=>p.NamePsl).FirstOrDefault();
            List<string> tags;
            if(newStatusId == "1")
            {
                tags = new List<string>() { "OrderModule_financialValidation" };
            }else if (newStatusId == "2" || newStatusId == "3")
            {
                tags = new List<string>() { userId, "OrderModule_managerValidation" };
            }else if(newStatusId == "4" || newStatusId == "5")
            {
                tags = new List<string>() { userId };
            }
            else
            {
                tags = new List<string>();
            }
            PushPayload pushPayload = new PushPayload()
            {
                Platform = new List<string> { "android"},
                Audience = new Audience { Tag = tags},
                Notification = new Notification
                {
                    Android = new Android
                    {
                        Alert = "订单号: " + orderId +
                        ", 由:"+ updateByName  + " ,变更为: " + utils.GetOrdersStatus(int.Parse(newStatusId)),
                        Title = orderTypeDescript+"状态更变"
                    }
                }
            };
            client.SendPush(pushPayload);


        }
    }
}
