using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<BoatStatusLogDto> GetAllDamagedBoats() => _uow.Uow(uow =>
        {
            var entities = uow.BoatStatusLogRepository.FindBy(bsl => !bsl.ReturnToServiceDate.HasValue)
            .OrderByDescending(bsl => bsl.RemovalOfServiceDate)
            .ToList();
            var dtos = _mapper.Map<List<BoatStatusLog>, List<BoatStatusLogDto>>(entities);

            return dtos;
        });

        public List<BoatStatusLogDto> SearchBoatStatusLog(BoatStatusLogSearchParameter searchParam) => _uow.Uow(uow =>
        {
            var entities = uow.BoatStatusLogRepository.Search(searchParam).ToList();
            var dtos = _mapper.Map<List<BoatStatusLog>, List<BoatStatusLogDto>>(entities);

            return dtos;
        });
    }
}
