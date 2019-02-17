using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Vesper.LogBook.Common
{
    public class LogBookDto
    {
        public LogBookDto()
        {
            LogBookId = 0;
            Date = SqlDateTime.MinValue.Value;
            TimeOut = SqlDateTime.MinValue.Value;
            Comment = string.Empty;
            BoatName = string.Empty;
            BoatType = string.Empty;
        }

        public int LogBookId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int? MilesRowed { get; set; }
        public string Comment { get; set; }
        public string BoatName { get; set; }
        public string BoatType { get; set; }

        public List<BoatingDto> Boatings { get; set; }
    }
}
