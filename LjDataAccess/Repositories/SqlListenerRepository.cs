using LjData.JpushModel;
using LjData.Utils;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        public SqlListenerRepository(NotificationEvent notificationEvent)
        {
            _notificationEvent = notificationEvent;
            this.utils = new Utils();
        }

        public void sendNotificationRequest(string appkey, string masterSecret ,string userId, string orderId, string oldStatusId, string newStatusId, string updateBy, string orderType)
        {
            JPushClient client = new JPushClient(appkey, masterSecret);
            string orderTypeDescript = utils.GetCommandTypeLabelById(orderType);
            PushPayload pushPayload = new PushPayload()
            {
                Platform = new List<string> { "android"},
                Audience = new Audience
                {
                    Alias = new List<string>() { userId}
                },
                Notification = new Notification
                {
                    Android = new Android
                    {
                        Alert = "订单 : " + orderId + 
                        ", 变更为 : " + utils.GetOrdersStatus(int.Parse(newStatusId)),
                        Title = "订单状态变更"
                    }
                }
            };
            client.SendPush(pushPayload);


        }
    }
}
