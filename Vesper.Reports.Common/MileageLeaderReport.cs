using System.Collections.Generic;

namespace Vesper.Reports.Common
{
    public class MileageLeaderReport
    {
        public MileageLeaderReport()
        {
            MileageLeaders = new List<MileageLeader>();
        }

        public MileageLeaderReport(List<MileageLeader> mileageLeaders)
        {
            MileageLeaders = mileageLeaders;
        }

        public List<MileageLeader> MileageLeaders { get; set; }
    }
}
