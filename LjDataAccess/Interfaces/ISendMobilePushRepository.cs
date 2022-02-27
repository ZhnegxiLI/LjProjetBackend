using System.Threading.Tasks;

namespace LjDataAccess.Interfaces
{
    public interface ISendMobilePushRepository
    {
        Task sendNotificationRequestAsync();
    }
}
