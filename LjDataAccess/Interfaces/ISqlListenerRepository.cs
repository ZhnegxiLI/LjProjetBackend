using System;
using System.Collections.Generic;
using System.Text;

namespace LjDataAccess.Interfaces
{
    public interface ISqlListenerRepository
    {
        string sendNotificationRequest(string appkey, string masterSecret, string userId, string orderId, string statusId, string updateBy, string orderType);
    }
}
