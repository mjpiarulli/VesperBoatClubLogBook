using System;
using System.Collections.Generic;
using Vesper.Reports.Common;

namespace Vesper.Reports.DataAccess.Interface
{
    public interface IReportRepository
    {
        Common.LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate);
        MileageLeaderReport GetMileageLeaderReport();
    }
}
