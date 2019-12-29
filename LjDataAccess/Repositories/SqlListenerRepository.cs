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
        private static JPushClient client = new JPushClient("","");
        public SqlListenerRepository(NotificationEvent notificationEvent)
        {
            _notificationEvent = notificationEvent;
        }

        public string sendNotificationRequest(string appkey, string masterSecret ,string userId, string orderId, string statusId, string updateBy, string orderType)
        {
            JPushClient client = new JPushClient(appkey, masterSecret);
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
                        Alert = "订单 : " + orderId + ", 变更为 : " + statusId,
                        Title = "订单状态变更"
                    }
                }
            };
            var response = client.SendPush(pushPayload);
            return response.Content;
            /*HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://api.jpush.cn/v3/push");
            myReq.Method = "POST";
            myReq.ContentType = "application/json";
            myReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(
                System.Text.Encoding.Default.GetBytes("90c6ff030b3870f48a3d3e7b:2a56bcd2612382e0fee79e57"))
                );

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            myReq.ProtocolVersion = HttpVersion.Version10;

            var data = new
            {
                platform = "[android]",
                audience = "all",
                notification = new
                {
                    android = new {
                        alert = "Hi, JPush!",
                        title =  "Send to Android",
                        builder_id = 1,
                        extras = new {
                            newsid =  321
                        }
                    },
                }
            };*/

            /*byte[] bs = UTF8Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            myReq.ContentLength = bs.Length;
            using (Stream reqStream = myReq.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)myReq.GetResponse();
            HttpStatusCode statusCode = response.StatusCode;
            if (Equals(response.StatusCode, HttpStatusCode.OK))
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8))
                {
                    string resultJson = reader.ReadToEnd();
                    object json = Newtonsoft.Json.JsonConvert.DeserializeObject(resultJson);
                }
            }*/


        }
    }
}
