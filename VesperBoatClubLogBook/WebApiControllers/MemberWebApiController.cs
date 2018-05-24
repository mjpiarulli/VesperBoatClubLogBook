using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/member")]
    public class MemberWebApiController : WebApiBaseController
    {
        [Route("LoadMemberList")]
        [HttpGet]
        public List<MemberDto> LoadMemberList()
        {
            var memberList = VesperLogBookService.GetMembersAlphabeticalByLastName();

            return memberList;
        }

        [Route("AddNewMember")]
        [HttpPost]
        public MemberDto AddNewMember(MemberDto dto)
        {
            var addedDto = VesperLogBookService.AddNewMember(dto);

            return addedDto;
        }

        [Route("GetMemberById")]
        [HttpGet]
        public MemberDto GetMemberById(int id)
        {
            var member = VesperLogBookService.GetMemberById(id);

            return member;
        }

        [Route("EditMember")]
        [HttpPost]
        public MemberDto EditMember([FromBody] MemberDto dto)
        {
            var editedDto = VesperLogBookService.EditMember(dto);

            return editedDto;
        }
    }
}