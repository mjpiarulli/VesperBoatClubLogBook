using System;
using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface ILogBookService
    {
        LogBookDto GetLogBookById(int id);
        int GetClubMileageYearToDate(DateTime date);
        List<LogBookDto> SearchLogBook(LogBookSearchParameter param);
        LogBookDto AddNewLog(LogBookDto dto);
        LogBookDto EditLog(LogBookDto dto);
    }
}
