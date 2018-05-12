namespace Vesper.LogBook.Common
{
    public class BoatingDto
    {
        public BoatingDto()
        {
            BoatingId = 0;
            LogBookId = 0;
            MemberId = 0;
            Seat = string.Empty;
            Order = 0;
        }

        public int BoatingId { get; set; }
        public int LogBookId { get; set; }
        public int MemberId { get; set; }
        public string Seat { get; set; }
        public int Order { get; set; }

        public MemberDto Member { get; set; }
        public LogBookDto LogBook { get; set; }
    }
}
