using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/boatstatuslog")]
    public class BoatStatusLogWebApiController : WebApiBaseController
    {
        [Route("LoadDamagedBoatList")]
        [HttpGet]
        public List<BoatStatusLogDto> LoadDamagedBoatList()
        {
            var list = VesperLogBookService.GetAllDamagedBoats();

            return list;
        }

        [Route("LoadBoatStatusLogSearch")]
        [HttpPost]
        public List<BoatStatusLogDto> LoadBoatStatusLogSearch([FromBody] BoatStatusLogSearchParameter searchParam)
        {
            var results = VesperLogBookService.SearchBoatStatusLog(searchParam);

            return results;
        }

        [Route("LoadBoatStatusLogById")]
        [HttpGet]
        public BoatStatusLogDto LoadBoatStatusLogById(int id)
        {
            var boatStatusLog = VesperLogBookService.GetBoatStatusLogById(id);

            return boatStatusLog;
        }

        [Route("EditBoatStatusLog")]
        [HttpPost]
        public BoatStatusLogDto EditBoatStatusLog([FromBody] BoatStatusLogDto dto)
        {
            var editedDto = VesperLogBookService.EditBoatStatusLog(dto);

            return editedDto;
        }

        [Route("AddNewBoatStatusLog")]
        [HttpPost]
        public BoatStatusLogDto AddNewBoatStatusLog([FromBody] BoatStatusLogDto dto)
        {
            var newDto = VesperLogBookService.AddNewBoatStatusLog(dto);

            return newDto;
        }
    }
}