using System;

namespace Vesper.Reports.DataAccess.Interface
{
    public interface IReportRepository
    {
        Common.LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
    }
}
