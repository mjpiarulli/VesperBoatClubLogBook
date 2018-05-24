using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<BoatStatusDto> GetAllBoatStatusesAlphabetical() => _uow.Uow(uow =>
        {
            var entities = uow.BoatStatusRepository.FindBy(bs => true)
                .OrderBy(bs => bs.Status)
                .ToList();
            var dtos = _mapper.Map<List<BoatStatu>, List<BoatStatusDto>>(entities);

            return dtos;
        });
    }
}
