using System;
using System.Collections.Generic;
using System.Text;

namespace LjDataAccess.Interfaces
{
    public interface ISqlListenerRepository
    {
        void sendNotificationRequest(string appkey, string masterSecret, string userId, string orderId, string oldStatusId, string newStatusId, string updateBy, string orderType);
    }
}
