namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class BoatsCheckedOutReportSqlHelper
    {
        public const string BoatsCheckedOutSql = @"
                                                    Select lb.LogBookId, lb.BoatName, lb.TimeOut As CheckOutTime
												                                                    ,Stuff((Select ', ' + b.Seat + ': ' + m.LastName
														                                                    From Boating b																												
														                                                    Join Member m
														                                                    On b.MemberId = m.MemberId														
														                                                    Where lb.LogBookId = b.LogBookId
														                                                    For Xml Path('')), 1, 2, '') Members
                                                    From LogBook lb
                                                    Where TimeIn Is NULL
	                                                    And MilesRowed Is NULL
	                                                    And TimeOut Is Not NULL
                                                        And BoatName Is Not NULL
                                                    Group By lb.LogBookId, lb.BoatName, lb.TimeOut
                                                    Order By TimeOut
                                                    ";
    }
}
