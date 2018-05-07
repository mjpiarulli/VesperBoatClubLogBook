using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/boattype")]
    public class BoatTypeWebApiController : WebApiBaseController
    {
        [Route("loadallboattypesbyseats")]
        [HttpGet]
        public List<BoatTypeDto> LoadAllBoatTypesBySeats()
        {
            var boatTypes = VesperLogBookService.GetAllBoatTypesBySeats();

            return boatTypes;
        }
    }
}