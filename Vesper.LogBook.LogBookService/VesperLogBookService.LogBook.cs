using System;
using System.Linq;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public int GetClubMileageYearToDate(DateTime date) => _uow.Uow(uow =>
        {
            var firstDateOfTheYear = new DateTime(date.Year, 1, 1);
            var mileage = uow.LogBookRepository.FindBy(lb => lb.Date.HasValue &&
                                                             lb.Date.Value >= firstDateOfTheYear &&
                                                             lb.Date.Value <= date &&
                                                             lb.MilesRowed.HasValue)
                                                             .Sum(lb => lb.MilesRowed.Value);

            return mileage;
        });
    }
}
