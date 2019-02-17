using System;
using Vesper.Reports.Common;

namespace Vesper.Reports.DataAccess.Interface
{
    public interface IReportRepository
    {
        LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
        BoatsCheckedOutReport GetBoatsCheckedOutReport();
        MileageLeaderReport GetMileageLeaderReport();
        IndividualMileageReport GetIndividualMileageReport(int memberId, DateTime startDate, DateTime endDate);
        ClubMileageByMemberReport GetClubMileageByMemberReport(DateTime startDate, DateTime endDate);
        ClubLogBookReport GetClubLogBookReport(DateTime startDate, DateTime endDate);
    }
}
