namespace Vesper.Reports.Common
{
    public class MileageAndUsageTotalEntry
    {
        public MileageAndUsageTotalEntry()
        {
            BoatType = string.Empty;
            MilesRowed = 0;
            Outings = 0;
        }

        public string BoatType { get; set; }
        public int MilesRowed { get; set; }
        public int Outings { get; set; }
    }
}
