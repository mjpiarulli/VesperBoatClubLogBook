using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/boatstatus")]
    public class BoatStatusWebApiController : WebApiBaseController
    {
        [Route("loadallboatstatusesalphabetical")]
        [HttpGet]
        public List<BoatStatusDto> LoadAllBoatStatusesAlphabetical()
        {
            var boatStatuses = VesperLogBookService.GetAllBoatStatusesAlphabetical();

            return boatStatuses;
        }
    }
}