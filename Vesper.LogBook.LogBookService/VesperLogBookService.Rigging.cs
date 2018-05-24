using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<RiggingDto> GetAllRiggingsAlphabetical() => _uow.Uow(uow =>
        {
            var entities = uow.RiggingRepository.FindBy(r => true)
                .OrderBy(r => r.Name)
                .ToList();
            var dtos = _mapper.Map<List<Rigging>, List<RiggingDto>>(entities);

            return dtos;
        });
    }
}
