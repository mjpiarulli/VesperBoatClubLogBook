using System;
using System.Data.SqlTypes;

namespace Vesper.Reports.Common
{
    public class IndividualMileageReportEntry
    {
        public IndividualMileageReportEntry()
        {
            LogBookId = 0;
            Date = SqlDateTime.MinValue.Value;
            BoatName = string.Empty;
            MilesRowed = 0;
            Comment = string.Empty;
        }

        public int LogBookId { get; set; }
        public DateTime Date { get; set; }
        public string BoatName { get; set; }
        public int MilesRowed { get; set; }
        public string Comment { get; set; }
    }
}
