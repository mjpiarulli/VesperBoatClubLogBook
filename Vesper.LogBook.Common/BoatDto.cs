namespace Vesper.LogBook.Common
{
    public class BoatDto
    {
        public BoatDto()
        {
            BoatId = 0;
            Name = string.Empty;
            Size = 0;
            Type = string.Empty;
        }

        public int BoatId { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string CurrentRigging { get; set; }
        public string RiggingAvailable { get; set; }
        public string UseRestrictions { get; set; }
        public string Status { get; set; }
        public string OwnedBy { get; set; }
    }
}
