using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/boattype")]
    public class BoatTypeWebApiController : WebApiBaseController
    {
        [Route("loadallboattypesorderedbyseats")]
        [HttpGet]
        public List<BoatTypeDto> LoadAllBoatTypesOrderedBySeats()
        {
            var boatTypes = VesperLogBookService.GetAllBoatTypesOrderedBySeats();

            return boatTypes;
        }
    }
}