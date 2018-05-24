using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/rigging")]
    public class RiggingWebApiController : WebApiBaseController
    {
        [Route("loadallriggingsalphabetical")]
        [HttpGet]
        public List<RiggingDto> LoadAllRiggingsAlphabetical()
        {
            var riggings = VesperLogBookService.GetAllRiggingsAlphabetical();

            return riggings;
        }
    }
}