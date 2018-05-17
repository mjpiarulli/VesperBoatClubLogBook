using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/member")]
    public class MemberWebApiController : WebApiBaseController
    {
        [Route("loadmemberlist")]
        [HttpGet]
        public List<MemberDto> LoadMemberList()
        {
            var memberList = VesperLogBookService.GetMembersAlphabeticalByLastName();

            return memberList;
        }

        [Route("addnewmember")]
        [HttpPost]
        public MemberDto AddNewMember(MemberDto dto)
        {
            var addedDto = VesperLogBookService.AddNewMember(dto);

            return addedDto;
        }
    }
}