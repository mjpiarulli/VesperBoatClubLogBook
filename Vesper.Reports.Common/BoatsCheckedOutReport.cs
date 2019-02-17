using System.Collections.Generic;

namespace Vesper.Reports.Common
{
    public class BoatsCheckedOutReport
    {
        public BoatsCheckedOutReport()
        {
            Boats = new List<BoatsCheckedOutEntry>();
        }

        public BoatsCheckedOutReport(List<BoatsCheckedOutEntry> boats)
        {
            Boats = boats;
        }

        public List<BoatsCheckedOutEntry> Boats { get; set; }
    }
}
