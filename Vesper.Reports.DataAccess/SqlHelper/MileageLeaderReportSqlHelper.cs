namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class MileageLeaderReportSqlHelper
    {
        public const string MileageLeaderReportSql = @"
                                                        Select top 5 m.FirstName, m.LastName, sum(lb.MilesRowed) as MilesRowed
                                                        from Member m
                                                        Join Boating b
                                                        On m.MemberId = b.MemberId
                                                        join LogBook lb
                                                        on b.LogBookId = lb.LogBookId
                                                        Where lb.Date > '1/1/2018'
                                                        Group By m.FirstName, m.LastName
                                                        Order By MilesRowed desc
                                                        ";
    }
}
