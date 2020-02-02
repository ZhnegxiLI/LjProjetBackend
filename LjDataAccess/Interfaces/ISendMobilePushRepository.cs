using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LjDataAccess.Interfaces
{
    public interface ISendMobilePushRepository
    {
         Task sendNotificationRequestAsync();
    }
}
