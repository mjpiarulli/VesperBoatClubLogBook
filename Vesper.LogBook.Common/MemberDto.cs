using System.Collections.Generic;

namespace Vesper.LogBook.Common
{
    public class MemberDto
    {
        public MemberDto()
        {
            MemberId = 0;
            LastName = string.Empty;
            FirstName = string.Empty;
            MiddleInitial = string.Empty;
        }

        public int MemberId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }

        public List<BoatingDto> Boatings { get; set; }
    }
}
