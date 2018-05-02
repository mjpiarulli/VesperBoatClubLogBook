namespace Vesper.LogBook.Common
{
    public class BoatTypeDto
    {
        public BoatTypeDto()
        {
            BoatTypeId = 0;
            Type = string.Empty;
            Name = string.Empty;
            Seats = 0;
            StartCount = 0;
            HasCox = false;
        }

        public int BoatTypeId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }
        public int StartCount { get; set; }
        public bool HasCox { get; set; }
    }
}
