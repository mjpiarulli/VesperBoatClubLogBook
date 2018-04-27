using System;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface ILogBookService
    {
        int GetClubMileageYearToDate(DateTime date);

    }
}
