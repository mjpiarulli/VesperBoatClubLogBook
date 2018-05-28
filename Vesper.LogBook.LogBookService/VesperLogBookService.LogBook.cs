using System;
using System.Collections.Generic;
using System.Linq;
using Vesper.LogBook.Common;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public int GetClubMileageYearToDate(DateTime date) => _uow.Uow(uow =>
        {
            var firstDateOfTheYear = new DateTime(date.Year, 1, 1);
            var mileage = uow.LogBookRepository.FindBy(lb => lb.Date >= firstDateOfTheYear &&
                                                             lb.Date <= date &&
                                                             lb.MilesRowed.HasValue)
                                                             .Sum(lb => lb.MilesRowed.Value);

            return mileage;
        });

        public List<LogBookDto> SearchLogBook(LogBookSearchParameter param) => _uow.Uow(uow =>
        {
            var dtos = uow.LogBookRepository.Search(param)
            .Select(lb => new LogBookDto
                {
                    Boatings = lb.Boatings.Select(b => new BoatingDto
                    {
                        Member = new MemberDto
                        {
                            FirstName = b.Member.FirstName,
                            LastName = b.Member.LastName
                        }
                    }).ToList(),
                    BoatName = lb.BoatName,
                    BoatType = lb.BoatType,
                    Comment = lb.Comment,
                    Date = lb.Date,
                    MilesRowed = lb.MilesRowed ?? 0,
                    TimeOut = lb.TimeOut ?? lb.Date,
                    TimeIn = lb.TimeIn ?? lb.Date
                })
            .ToList();

            return dtos;
        });

        public LogBookDto AddNewLog(LogBookDto dto) => _uow.Uow(uow =>
        {
            var entity = _mapper.Map<LogBookDto, DataAccess.LogBook>(dto);
            uow.LogBookRepository.Add(entity);
            uow.Save();
            dto.LogBookId = entity.LogBookId;

            return dto;
        });
    }
}
