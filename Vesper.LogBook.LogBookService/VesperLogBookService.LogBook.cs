using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vesper.LogBook.Common;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService
    {
        public LogBookDto GetLogBookById(int id) => _uow.Uow(uow =>
        {
            var entity = uow.LogBookRepository.Load(id);
            var dto = _mapper.Map<DataAccess.LogBook, LogBookDto>(entity);

            return dto;
        });

        public int GetClubMileageYearToDate(DateTime date) => _uow.Uow(uow =>
        {
            var firstDateOfTheYear = new DateTime(date.Year, 1, 1);
            var mileage = uow.LogBookRepository.FindBy(lb => lb.Date >= firstDateOfTheYear &&
                                                             lb.Date <= date &&
                                                             lb.MilesRowed.HasValue)
                                                             .AsNoTracking()
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
                        BoatingId = b.BoatingId,
                        LogBookId = b.LogBookId,
                        MemberId = b.MemberId,
                        Seat = b.Seat,
                        Order = b.Order,
                        Member = new MemberDto
                        {
                            MemberId = b.MemberId,
                            FirstName = b.Member.FirstName,
                            MiddleInitial = b.Member.MiddleInitial,
                            LastName = b.Member.LastName
                        }
                    }).ToList(),
                    BoatName = lb.BoatName,
                    BoatType = lb.BoatType,
                    Comment = lb.Comment,
                    Date = lb.Date,
                    LogBookId = lb.LogBookId,
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

        public LogBookDto EditLog(LogBookDto dto) => _uow.Uow(uow =>
        {
            dto.Boatings.ForEach(b => b.Member = null);
            var entity = _mapper.Map<LogBookDto, DataAccess.LogBook>(dto);
            foreach (var boating in entity.Boatings)
                uow.BoatingRepository.Edit(boating);
            uow.LogBookRepository.Edit(entity);
            uow.Save();

            return dto;
        });
    }
}
