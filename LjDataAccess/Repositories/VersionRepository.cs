using LjDataAccess.Interfaces;
using System.Linq;

namespace LjDataAccess.Repositories
{
    public class VersionRepository : IVersionRepository
    {
        private readonly ERPDATA2Context context;

        public VersionRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public string getMobileVersion()
        {
            return context.XyInfo.FirstOrDefault().mobileVersion;
        }

        public string getCompanyName()
        {
            return context.CpnyInfo.FirstOrDefault().entrepriseName;
        }
    }
}
