using System;
using Vesper.Reports.Common;

namespace Vesper.Reports.ReportServiceContract
{
    public interface IReportService
    {
        LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
    }
}
