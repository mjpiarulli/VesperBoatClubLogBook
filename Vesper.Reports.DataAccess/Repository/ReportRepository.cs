using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Vesper.Reports.Common;
using Vesper.Reports.DataAccess.Interface;
using Vesper.Reports.DataAccess.SqlHelper;
using LogBookMileageAndUsageByBoat = Vesper.Reports.Common.LogBookMileageAndUsageByBoat;

namespace Vesper.Reports.DataAccess.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly DbContext _context;

        public ReportRepository(DbContext context)
        {
            _context = context;
        }

        public LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate)
        {
            var p1 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate) };
            var p2 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate) };
            var p3 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate) };

            const string mileageAndUsageEntrySql = LogBookMileageAndUsageByBoatSqlHelper.MileageAndUsageEntrySql;
            const string mileageAndUsageTotalEntrySql = LogBookMileageAndUsageByBoatSqlHelper.MileageAndUsageTotalEntrySql;
            const string mileageAndUsageGrandTotalSql = LogBookMileageAndUsageByBoatSqlHelper.MileageAndUsageGrandTotalSql;

            var mileageAndUsageEntries = _context.Database.SqlQuery<MileageAndUsageEntry>(mileageAndUsageEntrySql, p1.ToArray()).ToList();
            var mileageAndUsageTotalEntry = _context.Database.SqlQuery<MileageAndUsageTotalEntry>(mileageAndUsageTotalEntrySql, p2.ToArray()).ToList();
            var mileageAndUsageGrandTotal = _context.Database.SqlQuery<MileageAndUsageGrandTotal>(mileageAndUsageGrandTotalSql, p3.ToArray()).FirstOrDefault();
            
            var logBookMileageAndUsageByBoat = new LogBookMileageAndUsageByBoat(mileageAndUsageEntries, mileageAndUsageTotalEntry, mileageAndUsageGrandTotal);

            return logBookMileageAndUsageByBoat;
        }

        public MileageLeaderReport GetMileageLeaderReport()
        {
            var currentYear = DateTime.Now.Year;
            var date = new DateTime(currentYear, 1, 1);
            var p1 = new List<object> {new SqlParameter("@date", date)};
            const string mileageLeaderReportSql = MileageLeaderReportSqlHelper.MileageLeaderReportSql;

            var mileageLeaders = _context.Database.SqlQuery<MileageLeader>(mileageLeaderReportSql, p1.ToArray()).ToList();
            var mileageLeaderReport = new MileageLeaderReport(mileageLeaders);

            return mileageLeaderReport;
        }

        public IndividualMileageReport GetIndividualMileageReport(int memberId, DateTime startDate, DateTime endDate)
        {
            var p1 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate), new SqlParameter("@memberId", memberId) };
            var p2 = new List<object> { new SqlParameter("@startDate", startDate), new SqlParameter("@endDate", endDate), new SqlParameter("@memberId", memberId) };
            const string individualMileageReportSql = IndividualMileageReportSqlHelper.IndividualMileageReportSql;
            const string totalMilesRowedSql = IndividualMileageReportSqlHelper.TotalMilesRowedSql;
            var entries = _context.Database.SqlQuery<IndividualMileageReportEntry>(individualMileageReportSql, p1.ToArray()).ToList();
            var totalMilesRowed = _context.Database.SqlQuery<int>(totalMilesRowedSql, p2.ToArray()).First();
            var report = new IndividualMileageReport(entries, totalMilesRowed);

            return report;
        }
    }
}
