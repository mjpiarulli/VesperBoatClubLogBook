using System;
using Vesper.Reports.Common;

namespace Vesper.Reports.DataAccess.Interface
{
    public interface IReportRepository
    {
        LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
        MileageLeaderReport GetMileageLeaderReport();
        IndividualMileageReport GetIndividualMileageReport(int memberId, DateTime startDate, DateTime endDate);
    }
}
