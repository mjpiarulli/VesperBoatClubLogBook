using System;
using System.Data.SqlTypes;

namespace Vesper.Reports.Common
{
    public class BoatsCheckedOutEntry
    {
        public BoatsCheckedOutEntry()
        {
            BoatName = string.Empty;
            CheckOutTime = SqlDateTime.MinValue.Value;
            LogBookId = 0;
        }

        public BoatsCheckedOutEntry(string boatName, DateTime checkOutTime, int logBookId)
        {
            BoatName = boatName;
            CheckOutTime = checkOutTime;
            LogBookId = logBookId;
        }

        public string BoatName { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int LogBookId { get; set; }
    }
}
