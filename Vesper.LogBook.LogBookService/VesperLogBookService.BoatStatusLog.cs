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

        public BoatStatusLogDto GetBoatStatusLogById(int id) => _uow.Uow(uow =>
        {
            var entity = uow.BoatStatusLogRepository.Load(id);
            var dto = _mapper.Map<BoatStatusLog, BoatStatusLogDto>(entity);

            return dto;
        });

        public BoatStatusLogDto EditBoatStatusLog(BoatStatusLogDto dto) => _uow.Uow(uow =>
        {
            var entity = uow.BoatStatusLogRepository.Load(dto.BoatStatusLogId);
            _mapper.Map(dto, entity);
            uow.BoatStatusLogRepository.Edit(entity);
            uow.Save();

            return dto;
        });

        public BoatStatusLogDto AddNewBoatStatusLog(BoatStatusLogDto dto) => _uow.Uow(uow =>
        {
            var entity = _mapper.Map<BoatStatusLogDto, BoatStatusLog>(dto);
            uow.BoatStatusLogRepository.Add(entity);
            uow.Save();
            dto.BoatStatusLogId = entity.BoatStatusLogId;

            return dto;
        });
    }
}
