namespace Vesper.Reports.Common
{
    public class MileageLeader
    {
        public MileageLeader()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            MilesRowed = 0;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MilesRowed { get; set; }
    }
}
