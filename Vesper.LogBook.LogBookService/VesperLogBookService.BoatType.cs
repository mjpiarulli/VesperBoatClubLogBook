using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<BoatTypeDto> GetAllBoatTypesBySeats() => _uow.Uow(uow =>
        {
            var entities = uow.BoatTypeRepository.FindBy(bt => true)
                .OrderBy(bt => bt.Seats)
                .ToList();
            var dtos = _mapper.Map<List<BoatType>, List<BoatTypeDto>>(entities);

            return dtos;
        });
    }
}
