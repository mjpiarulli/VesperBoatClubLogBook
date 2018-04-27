using System;

namespace Vesper.LogBook.Common
{
    public class LogBookDto
    {
        public LogBookDto()
        {
            LogBookId = 0;
        }

        public int LogBookId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int MilesRowed { get; set; }
        public string Comment { get; set; }
        public string BoatName { get; set; }
        public string BoatType { get; set; }
    }
}
