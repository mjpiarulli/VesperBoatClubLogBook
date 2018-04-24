using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class LogBookService
    {
        public List<MemberDto> GetMembersAlphabeticalByLastName() => _uow.Uow(uow =>
        {
            var entities = uow.MemberRepository.FindBy(m => true)
                .OrderBy(m => m.LastName)
                .ToList();
            var dtos = _mapper.Map<List<Member>, List<MemberDto>>(entities);

            return dtos;
        });
    }
}
