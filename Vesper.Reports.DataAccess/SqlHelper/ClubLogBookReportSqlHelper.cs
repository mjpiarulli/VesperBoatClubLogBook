namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class ClubLogBookReportSqlHelper
    {
        public const string ClubLogBookReportSql = @"
                                                    Select Distinct lb.Date, lb.BoatName, lb.BoatType, IsNull(lb.Comment, '') As Comment
                                                        , IsNull(lb.TimeOut, lb.Date) As TimeOut, IsNull(lb.TimeIn, lb.Date) As TimeIn, lb.MilesRowed,
	                                                    Stuff((Select Distinct ', ' + m1.FirstName + ' ' + m1.LastName
			                                                    From Member m1
			                                                    Join Boating b1
			                                                    On m1.MemberId = b1.MemberId			
			                                                    Where b1.LogBookId = b.LogBookId
			                                                    For XML Path(''), type
			                                                    ).value('.', 'nvarchar(max)')
			                                                    ,1,1,'') Crew
                                                    From LogBook lb
                                                    Join Boating b
                                                    on lb.LogBookId = b.LogBookId
                                                    Join Member m
                                                    On b.MemberId = m.MemberId
                                                    Where lb.Date Between @startDate And @endDate
                                                    Order By lb.Date, TimeOut
                                                    ";
    }
}
