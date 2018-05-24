using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/userestriction")]
    public class UseRestrictionWebApiController : WebApiBaseController
    {
        [Route("loadalluserestrictionsalphabetical")]
        [HttpGet]
        public List<UseRestrictionDto> LoadAllUseRestrictionsAlphabetical()
        {
            var useRestrictions = VesperLogBookService.GetAllUseRestrictionsAlphabetical();

            return useRestrictions;
        }
    }
}