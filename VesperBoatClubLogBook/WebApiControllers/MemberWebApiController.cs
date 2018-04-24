using System.Collections.Generic;
using System.Web.Mvc;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    public class MemberWebApiController : WebApiBaseController
    {
        [Route("api/member/loadmemberlist")]
        public List<MemberDto> LoadMemberList()
        {
            var memberList = LogBookService.GetMembersAlphabeticalByLastName();

            return memberList;
        }
    }
}