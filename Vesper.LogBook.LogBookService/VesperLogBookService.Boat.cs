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

        public BoatDto AddNewBoat(BoatDto dto) => _uow.Uow(uow =>
        {
            var entity = _mapper.Map<BoatDto, Boat>(dto);
            uow.BoatRepository.Add(entity);
            uow.Save();
            dto.BoatId = entity.BoatId;

            return dto;
        });

        public BoatDto GetBoatById(int id) => _uow.Uow(uow =>
        {
            var entity = uow.BoatRepository.Load(id);
            var dto = _mapper.Map<Boat, BoatDto>(entity);

            return dto;
        });

        public BoatDto EditBoat(BoatDto dto) => _uow.Uow(uow =>
        {
            var entity = uow.BoatRepository.Load(dto.BoatId);
            _mapper.Map(dto, entity);
            uow.BoatRepository.Edit(entity);
            uow.Save();

            return dto;
        });
    }
}
