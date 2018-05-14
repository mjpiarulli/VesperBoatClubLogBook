namespace Vesper.Reports.Common
{
    public class MemberMileageEntry
    {
        public MemberMileageEntry()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            MilesRowed = 0;
            Outings = 0;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MilesRowed { get; set; }
        public int Outings { get; set; }
    }
}
