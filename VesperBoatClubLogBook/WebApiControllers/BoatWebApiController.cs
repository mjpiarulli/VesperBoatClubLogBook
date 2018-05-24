using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/boat")]
    public class BoatWebApiController : WebApiBaseController
    {
        [Route("LoadBoatList")]
        [HttpGet]
        public List<BoatDto> LoadBoatList()
        {
            var boats = VesperLogBookService.GetAllBoatsAlphabetical();

            return boats;
        }

        [Route("LoadBoatsByBoatType")]
        [HttpGet]
        public List<BoatDto> LoadBoatsByBoatType(string boatType)
        {
            var boats = VesperLogBookService.GetBoatsByBoatType(boatType);

            return boats;
        }

        [Route("AddNewBoat")]
        [HttpPost]
        public BoatDto AddNewBoat(BoatDto dto)
        {
            var addedDto = VesperLogBookService.AddNewBoat(dto);

            return addedDto;
        }

        [Route("GetBoatById")]
        [HttpGet]
        public BoatDto GetBoatById(int id)
        {
            var boat = VesperLogBookService.GetBoatById(id);

            return boat;
        }

        [Route("EditBoat")]
        [HttpPost]
        public BoatDto EditBoat([FromBody] BoatDto dto)
        {
            var editedDto = VesperLogBookService.EditBoat(dto);

            return editedDto;
        }

    }
}