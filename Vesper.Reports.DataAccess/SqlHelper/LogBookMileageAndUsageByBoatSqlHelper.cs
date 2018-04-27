using System;

namespace Vesper.Reports.DataAccess
{
    public static class LogBookMileageAndUsageByBoat
    {
        public const string MileageAndUsageEntrySql = @"
                                                select BoatName, BoatType, Sum(MilesRowed) as MilesRowed, count(0) as Outings
                                                from logbook
                                                where [date] between @startDate and @endDate
                                                group by BoatName, BoatType
                                                order by BoatType
";
    }
}
