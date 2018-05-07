using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public List<BoatDto> GetAllBoatsAlphabetical() => _uow.Uow(uow =>
        {
            var entities = uow.BoatRepository.FindBy(b => true)
            .OrderBy(b => b.Name)
            .ToList();
            var dto = _mapper.Map<List<Boat>, List<BoatDto>>(entities);

            return dto;
        });

        public List<BoatDto> GetBoatsByBoatType(string boatType) => _uow.Uow(uow =>
        {
            var entities = uow.BoatRepository.FindBy(b => b.Type == boatType)
                .OrderBy(b => b.Name)
                .ToList();
            var dtos = _mapper.Map<List<Boat>, List<BoatDto>>(entities);

            return dtos;
        });
    }
}
