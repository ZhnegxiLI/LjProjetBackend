using LjData.Utils;
using LjDataAccess.Interfaces;
using System;
using System.Text;

namespace LjDataAccess.Repositories
{
    public class SseRepository : ISseRepository
    {
        private readonly ERPDATA2Context context;
        private NotificationEvent _notificationEvent;


        public SseRepository(ERPDATA2Context context, NotificationEvent notificationEvent)
        {
            this.context = context;
            _notificationEvent = notificationEvent;
        }
        /// <summary>
        /// product sse data
        /// </summary>
        /// <param name="data">内容</param>
        /// <param name="id"></param>
        /// <param name="_event">自定义事件</param>
        /// <param name="retry">重新发送间隔时间</param>
        /// <returns></returns>
        private string ServerSentEventData(string data, string id, string _event = "message", long retry = 10000)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("retry:{0}\n", retry);
            sb.AppendFormat("event:{0}\n", _event);
            sb.AppendFormat("id:{0}\n", id);
            sb.AppendFormat("data:{0}\n\n", data);
            return sb.ToString();
        }

        public string ProductSseData()
        {
            if (_notificationEvent.hasSet)
            {
                _notificationEvent.hasSet = false;
                return ServerSentEventData($"has receive data : {_notificationEvent.data}", "0", "push"); //如果检测到数据库变化

            }
            else
            {
                return ServerSentEventData($"controllers at {DateTime.Now}", "1"); //正常输出
            }
        }

    }
}
