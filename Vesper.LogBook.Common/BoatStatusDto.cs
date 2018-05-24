namespace Vesper.LogBook.Common
{
    public class BoatStatusDto
    {
        public BoatStatusDto()
        {
            BoatStatusId = 0;
            Status = string.Empty;
        }

        public int BoatStatusId { get; set; }
        public string Status { get; set; }
    }
}
