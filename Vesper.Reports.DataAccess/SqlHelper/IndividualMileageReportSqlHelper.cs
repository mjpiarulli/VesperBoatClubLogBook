namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class IndividualMileageReportSqlHelper
    {
        public const string IndividualMileageReportSql = @"
                                                            Select lb.LogBookId, lb.Date, lb.BoatName, lb.MilesRowed, IsNull(lb.Comment, '') As Comment
                                                            From LogBook lb
                                                            Join Boating b
                                                            On lb.LogBookId = b.LogBookId
                                                            Where b.MemberId = @memberId
	                                                            And lb.Date > @startDate
	                                                            And lb.Date < @endDate
                                                            Order By lb.Date
                                                            ";

        public const string TotalMilesRowedSql = @"
                                                Select IsNull(Sum(lb.MilesRowed), 0) As TotalMilesRowed
                                                From LogBook lb
                                                Join Boating b
                                                On lb.LogBookId = b.LogBookId
                                                Where b.MemberId = @memberId
	                                                And lb.Date > @startDate
	                                                And lb.Date < @endDate
                                                ";

    }
}
