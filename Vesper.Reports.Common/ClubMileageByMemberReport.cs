using System.Collections.Generic;

namespace Vesper.Reports.Common
{
    public class ClubMileageByMemberReport
    {
        public ClubMileageByMemberReport()
        {
            MemberMileageEntries = new List<MemberMileageEntry>();
        }

        public ClubMileageByMemberReport(List<MemberMileageEntry> memberMileageEntries)
        {
            MemberMileageEntries = memberMileageEntries;
        }

        public List<MemberMileageEntry> MemberMileageEntries { get; set; }
    }
}
