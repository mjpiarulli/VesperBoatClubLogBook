namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class ClubMileageByMemberReportSqlHelper
    {
        public const string ClubMileageByMemberReportSql = @"
                            Select m.FirstName, m.LastName, IsNull(Sum(lb.MilesRowed), 0) As MilesRowed, IsNull(Count(0), 0) As Outings
                            From LogBook lb
                            Join Boating b
                            On lb.LogBookId = b.LogBookId
                            Join Member m
                            On b.MemberId = m.MemberId
                            Where lb.Date Between @startDate And @endDate
                            Group By m.FirstName, m.LastName
                            Order By m.LastName
                            ";
    }
}
