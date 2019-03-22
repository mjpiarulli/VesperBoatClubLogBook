using System;
using System.Data.SqlTypes;

namespace Vesper.Reports.Common
{
    public class BoatsCheckedOutEntry
    {
        public BoatsCheckedOutEntry()
        {
            LogBookId = 0;
            BoatName = string.Empty;
            CheckOutTime = SqlDateTime.MinValue.Value;
            Members = string.Empty;
        }

        public BoatsCheckedOutEntry(int logBookId, string boatName, DateTime checkOutTime, string members)
        {
            LogBookId = logBookId;
            BoatName = boatName;
            CheckOutTime = checkOutTime;
            Members = members;
        }

        public int LogBookId { get; set; }
        public string BoatName { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string Members { get; set; }
    }
}
