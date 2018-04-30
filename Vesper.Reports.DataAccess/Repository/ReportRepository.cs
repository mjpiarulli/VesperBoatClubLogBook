using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Vesper.Reports.Common;
using Vesper.Reports.DataAccess.Interface;

namespace Vesper.Reports.DataAccess.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly DbContext _context;

        public ReportRepository(DbContext context)
        {
            _context = context;
        }

        public Common.LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate)
        {
            var p1 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate) };
            var p2 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate) };
            var p3 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate) };

            const string mileageAndUsageEntrySql = SqlHelper.LogBookMileageAndUsageByBoat.MileageAndUsageEntrySql;
            const string mileageAndUsageTotalEntrySql = SqlHelper.LogBookMileageAndUsageByBoat.MileageAndUsageTotalEntrySql;
            const string mileageAndUsageGrandTotalSql = SqlHelper.LogBookMileageAndUsageByBoat.MileageAndUsageGrandTotalSql;

            var mileageAndUsageEntries = _context.Database.SqlQuery<MileageAndUsageEntry>(mileageAndUsageEntrySql, p1.ToArray()).ToList();
            var mileageAndUsageTotalEntry = _context.Database.SqlQuery<MileageAndUsageTotalEntry>(mileageAndUsageTotalEntrySql, p2.ToArray()).ToList();
            var mileageAndUsageGrandTotal = _context.Database.SqlQuery<MileageAndUsageGrandTotal>(mileageAndUsageGrandTotalSql, p3.ToArray()).FirstOrDefault();
            
            var logBookMileageAndUsageByBoat = new LogBookMileageAndUsageByBoat(mileageAndUsageEntries, mileageAndUsageTotalEntry, mileageAndUsageGrandTotal);

            return logBookMileageAndUsageByBoat;
        }
    }
}
