using System;
using System.Web.Http;
using Vesper.Reports.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/report")]
    public class ReportWebApiController : WebApiBaseController
    {
        [Route("LoadLogBookMileageAndUsageByBoatReport")]
        [HttpGet]
        public LogBookMileageAndUsageByBoat LoadLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate)
        {
            var report = ReportService.GetLogBookMileageAndUsageByBoatReport(startDate, endDate);

            return report;
        }
    }
}