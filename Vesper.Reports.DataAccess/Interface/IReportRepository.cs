using System;

namespace Vesper.Reports.DataAccess.Interface
{
    public interface IReportRepository
    {
        Common.LogBookMileageAndUsageByBoat LoadLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
    }
}
