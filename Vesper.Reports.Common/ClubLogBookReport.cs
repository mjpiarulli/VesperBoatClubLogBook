using System.Collections.Generic;

namespace Vesper.Reports.Common
{
    public class ClubLogBookReport
    {
        public ClubLogBookReport()
        {
            ClubLogBookEntries = new List<ClubLogBookEntry>();
        }

        public ClubLogBookReport(List<ClubLogBookEntry> clubLogBookEntires)
        {
            ClubLogBookEntries = clubLogBookEntires;
        }

        public List<ClubLogBookEntry> ClubLogBookEntries { get; set; }
    }
}
