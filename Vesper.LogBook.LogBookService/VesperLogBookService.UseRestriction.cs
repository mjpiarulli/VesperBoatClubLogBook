using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<UseRestrictionDto> GetAllUseRestrictionsAlphabetical() => _uow.Uow(uow =>
        {
            var entities = uow.UseRestrictionRepository.FindBy(ur => true)
                .OrderBy(ur => ur.Restriction)
                .ToList();
            var dtos = _mapper.Map<List<UseRestriction>, List<UseRestrictionDto>>(entities);

            return dtos;
        });
    }
}
