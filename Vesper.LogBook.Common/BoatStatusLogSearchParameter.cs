using System;

namespace Vesper.LogBook.Common
{
    public class BoatStatusLogSearchParameter
    {
        public BoatStatusLogSearchParameter()
        {
            BoatName = string.Empty;
            Comments = string.Empty;
            CommentOnReturn = string.Empty;
        }

        public string BoatName { get; set; }
        public DateTime? RemovalOfServiceStartDate { get; set; }
        public DateTime? RemovalOfServiceEndDate { get; set; }
        public string Comments { get; set; }
        public DateTime? ReturnToServiceStartDate { get; set; }
        public DateTime? ReturnToServiceEndDate { get; set; }
        public string CommentOnReturn { get; set; }
    }
}
