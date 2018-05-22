using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/boat")]
    public class BoatWebApiController : WebApiBaseController
    {
        [Route("loadboatlist")]
        [HttpGet]
        public List<BoatDto> LoadBoatList()
        {
            var boats = VesperLogBookService.GetAllBoatsAlphabetical();

            return boats;
        }

        [Route("loadboatsbyboattype")]
        [HttpGet]
        public List<BoatDto> LoadBoatsByBoatType(string boatType)
        {
            var boats = VesperLogBookService.GetBoatsByBoatType(boatType);

            return boats;
        }

        [Route("addnewboat")]
        [HttpPost]
        public BoatDto AddNewBoat(BoatDto dto)
        {
            var addedDto = VesperLogBookService.AddNewBoat(dto);

            return addedDto;
        }

    }
}