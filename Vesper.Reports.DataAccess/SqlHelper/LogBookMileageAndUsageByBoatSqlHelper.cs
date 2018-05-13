namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class LogBookMileageAndUsageByBoatSqlHelper
    {
        public const string MileageAndUsageEntrySql = @"
                                                        select BoatName, BoatType, Sum(MilesRowed) as MilesRowed, count(0) as Outings
                                                        from logbook
                                                        where [date] between @startDate and @endDate
                                                        group by BoatName, BoatType
                                                        order by BoatType
                                                        ";

        public const string MileageAndUsageTotalEntrySql = @"
                                                            select BoatType, Sum(MilesRowed) as MilesRowed, count(0) as Outings
                                                            from logbook
                                                            where [date] between @startDate and @endDate
                                                            group by BoatType
                                                            order by BoatType
                                                            ";

        public const string MileageAndUsageGrandTotalSql = @"
                                                            select Sum(MilesRowed) as MilesRowed, count(0) as Outings
                                                            from logbook
                                                            where [date] between @startDate and @endDate
                                                            ";
    }
}
