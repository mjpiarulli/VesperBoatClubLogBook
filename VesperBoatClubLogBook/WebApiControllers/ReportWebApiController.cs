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

        [Route("LoadBoatsCheckedOutReport")]
        [HttpGet]
        public BoatsCheckedOutReport LoadBoatsCheckedOutReport()
        {
            var report = ReportService.GetBoatsCheckedOutReport();

            return report;
        }
        

        [Route("LoadMileageLeaderReport")]
        [HttpGet]
        public MileageLeaderReport LoadMileageLeaderReport()
        {
            var report = ReportService.GetMileageLeaderReport();

            return report;
        }

        [Route("LoadIndividualMileageReport")]
        [HttpGet]
        public IndividualMileageReport LoadIndividualMileageReport(int memberId, DateTime startDate, DateTime endDate)
        {
            var report = ReportService.GetIndividualMileageReport(memberId, startDate, endDate);

            return report;
        }

        [Route("LoadClubMileageByMemberReport")]
        [HttpGet]
        public ClubMileageByMemberReport LoadClubMileageByMemberReport(DateTime startDate, DateTime endDate)
        {
            var report = ReportService.GetClubMileageByMemberReport(startDate, endDate);

            return report;
        }

        [Route("LoadClubLogBookReport")]
        [HttpGet]
        public ClubLogBookReport LoadClubLogBookReport(DateTime startDate, DateTime endDate)
        {
            var report = ReportService.GetClubLogBookReport(startDate, endDate);

            return report;
        }
    }
}