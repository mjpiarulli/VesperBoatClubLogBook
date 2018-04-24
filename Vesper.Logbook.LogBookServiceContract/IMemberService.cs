using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface IMemberService
    {
        List<MemberDto> GetMembersAlphabeticalByLastName();
    }
}
