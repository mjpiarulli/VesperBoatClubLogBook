using System;
using System.Web.Http;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/logbook")]
    public class LogBookWebApiController : WebApiBaseController
    {
        [Route("loadclubmileageyeartodate")]
        [HttpGet]
        public int LoadClubMileageYearToDate()
        {
            var mileage = VesperLogBookService.GetClubMileageYearToDate(DateTime.Now);

            return mileage;
        }

        [Route("loadclubmileagelastyeartodate")]
        [HttpGet]
        public int LoadClubMileageLastYearToDate()
        {
            var mileage = VesperLogBookService.GetClubMileageYearToDate(DateTime.Now.AddYears(-1));

            return mileage;
        }
    }
}