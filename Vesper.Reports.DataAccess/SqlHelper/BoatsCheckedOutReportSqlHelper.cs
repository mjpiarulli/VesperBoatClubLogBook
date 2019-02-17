namespace Vesper.Reports.DataAccess.SqlHelper
{
    public static class BoatsCheckedOutReportSqlHelper
    {
        public const string BoatsCheckedOutSql = @"Select BoatName, TimeOut As CheckOutTime, LogBookId
                                                    From LogBook
                                                    Where TimeIn Is NULL
                                                    And MilesRowed Is NULL
                                                    And TimeOut Is Not NULL
                                                        And BoatName Is Not NULL
                                                    Order By TimeOut
                                                    ";
    }
}
