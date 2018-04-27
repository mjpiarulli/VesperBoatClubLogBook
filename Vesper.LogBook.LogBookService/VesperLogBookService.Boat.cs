using System.Collections.Generic;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<BoatDto> GetAllBoats() => _uow.Uow(uow =>
        {
            var entities = uow.BoatRepository.LoadAll();
            var dto = _mapper.Map<IList<Boat>, List<BoatDto>>(entities);

            return dto;
        });
    }
}
