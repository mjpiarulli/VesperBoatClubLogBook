using System;
using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface ILogBookService
    {
        int GetClubMileageYearToDate(DateTime date);
        List<LogBookDto> SearchLogBook(LogBookSearchParameter param);
    }
}
