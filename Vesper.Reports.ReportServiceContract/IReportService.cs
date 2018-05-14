using System;
using Vesper.Reports.Common;

namespace Vesper.Reports.ReportServiceContract
{
    public interface IReportService
    {
        LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
        MileageLeaderReport GetMileageLeaderReport();
        IndividualMileageReport GetIndividualMileageReport(int memberId, DateTime startDate, DateTime endDate);
        ClubMileageByMemberReport GetClubMileageByMemberReport(DateTime startDate, DateTime endDate);
    }
}
