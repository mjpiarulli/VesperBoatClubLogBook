using AutoMapper;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public static class AutomapperBootstrapper
    {
        public static IMapper MapVesperLogBook()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BoatDto, Boat>();
                cfg.CreateMap<Boat, BoatDto>();
                cfg.CreateMap<BoatingDto, Boating>();
                cfg.CreateMap<Boating, BoatingDto>();
                cfg.CreateMap<BoatStatusDto, BoatStatu>();
                cfg.CreateMap<BoatStatu, BoatStatusDto>();
                cfg.CreateMap<BoatStatusLogDto, BoatStatusLog>();
                cfg.CreateMap<BoatStatusLog, BoatStatusLogDto>();
                cfg.CreateMap<BoatTypeDto, BoatType>();
                cfg.CreateMap<BoatType, BoatTypeDto>();
                cfg.CreateMap<LogBookDto, DataAccess.LogBook>();
                cfg.CreateMap<DataAccess.LogBook, LogBookDto>().MaxDepth(1);
                cfg.CreateMap<MemberDto, Member>();
                cfg.CreateMap<Member, MemberDto>();
                cfg.CreateMap<RiggingDto, Rigging>();
                cfg.CreateMap<Rigging, RiggingDto>();
                cfg.CreateMap<UseRestrictionDto, UseRestriction>();
                cfg.CreateMap<UseRestriction, UseRestrictionDto>();
            }).CreateMapper();
        }

        public static IMapper MapLogBook()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LogBookDto, DataAccess.LogBook>()
                    .ForMember(l => l.Boatings, o => o.Ignore());
                cfg.CreateMap<DataAccess.LogBook, LogBookDto>()
                    .ForMember(l => l.Boatings, o => o.Ignore());
            }).CreateMapper();
        }

        public static IMapper MapMember()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MemberDto, Member>()
                    .ForMember(m => m.Boatings, o => o.Ignore());
                cfg.CreateMap<Member, MemberDto>()
                    .ForMember(m => m.Boatings, o => o.Ignore());
            }).CreateMapper();
        }
    }
}
