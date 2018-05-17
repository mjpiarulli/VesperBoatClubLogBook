using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<MemberDto> GetMembersAlphabeticalByLastName() => _uow.Uow(uow =>
        {
            var entities = uow.MemberRepository.FindBy(m => true)
                .OrderBy(m => m.LastName)
                .ToList();
            var mapper = AutomapperBootstrapper.MapMember();
            var dtos = mapper.Map<List<Member>, List<MemberDto>>(entities);

            return dtos;
        });

        public MemberDto AddNewMember(MemberDto dto) => _uow.Uow(uow =>
        {
            var entity = _mapper.Map<MemberDto, Member>(dto);
            uow.MemberRepository.Add(entity);
            uow.Save();
            dto.MemberId = entity.MemberId;

            return dto;
        });
    }
}
