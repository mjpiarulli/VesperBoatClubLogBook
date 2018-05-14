using System;

namespace Vesper.LogBook.Common
{
    public class LogBookSearchParameter
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string BoatName { get; set; }
        public string BoatType { get; set; }
        public int? MemberId { get; set; }
        public string Comment { get; set; }
    }
}
