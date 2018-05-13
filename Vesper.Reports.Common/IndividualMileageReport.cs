using System.Collections.Generic;

namespace Vesper.Reports.Common
{
    public class IndividualMileageReport
    {
        public IndividualMileageReport()
        {
            IndividualMileageReportEntries = new List<IndividualMileageReportEntry>();
        }

        public IndividualMileageReport(List<IndividualMileageReportEntry> individualMileageReportEntries, int totalMilesRowed)
        {
            IndividualMileageReportEntries = individualMileageReportEntries;
            TotalMilesRowed = totalMilesRowed;
        }

        public List<IndividualMileageReportEntry> IndividualMileageReportEntries { get; set; }
        public int TotalMilesRowed { get; set; }
    }
}
