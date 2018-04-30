namespace Vesper.Reports.Common
{
    public class MileageAndUsageEntry
    {
        public MileageAndUsageEntry()
        {
            BoatType = string.Empty;
            BoatName = string.Empty;
            MilesRowed = 0;
            Outings = 0;
        }

        public string BoatType { get; set; }
        public string BoatName { get; set; }
        public int MilesRowed { get; set; }
        public int Outings { get; set; }
    }
}
