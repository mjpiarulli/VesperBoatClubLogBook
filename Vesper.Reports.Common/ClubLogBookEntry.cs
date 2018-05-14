using System;
using System.Data.SqlTypes;

namespace Vesper.Reports.Common
{
    public class ClubLogBookEntry
    {
        public ClubLogBookEntry()
        {
            Date = SqlDateTime.MinValue.Value;
            BoatName = string.Empty;
            BoatType = string.Empty;
            Comment = string.Empty;
            TimeOut = SqlDateTime.MinValue.Value;
            TimeIn = SqlDateTime.MinValue.Value;
            MilesRowed = 0;
            Crew = string.Empty;
        }

        public DateTime Date { get; set; }
        public string BoatName { get; set; }
        public string BoatType { get; set; }
        public string Comment { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime TimeIn { get; set; }
        public int MilesRowed { get; set; }
        public string Crew { get; set; }
    }
}
