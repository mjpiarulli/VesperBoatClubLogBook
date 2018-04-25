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
            var boats = LogBookService.GetAllBoats();

            return boats;
        }
    }
}