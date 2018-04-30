using System;
using System.Data.SqlTypes;

namespace Vesper.LogBook.Common
{
    public class BoatStatusLogDto
    {
        public BoatStatusLogDto()
        {
            BoatStatusLogId = 0;
            BoatName = string.Empty;
            Status = string.Empty;
            Comments = string.Empty;
            RemovalOfServiceDate = SqlDateTime.MinValue.Value;
            CommentOnReturn = string.Empty;
        }

        public int BoatStatusLogId { get; set; }
        public string BoatName { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime RemovalOfServiceDate { get; set; }
        public string CommentOnReturn { get; set; }
        public DateTime? ReturnToServiceDate { get; set; }
    }
}
