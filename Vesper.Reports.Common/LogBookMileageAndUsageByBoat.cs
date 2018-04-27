using System.Collections.Generic;

namespace Vesper.Reports.Common
{
    public class LogBookMileageAndUsageByBoat
    {
        public LogBookMileageAndUsageByBoat()
        {
            MileageAndUsageEntries = new List<MileageAndUsageEntry>();
            MileageAndUsageTotalEntries = new List<MileageAndUsageTotalEntry>();
            MileageAndUsageGrandTotal = new MileageAndUsageGrandTotal();
        }

        public List<MileageAndUsageEntry> MileageAndUsageEntries { get; set; }
        public List<MileageAndUsageTotalEntry> MileageAndUsageTotalEntries { get; set; }
        public MileageAndUsageGrandTotal MileageAndUsageGrandTotal { get; set; }
    }
}
