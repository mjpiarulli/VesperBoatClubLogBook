using AutoMapper;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess;

namespace Vesper.LogBook.LogBookService
{
    public static class AutomapperBootstrapper
    {
        public static IMapper MapLogBook()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BoatDto, Boat>();
                cfg.CreateMap<Boat, BoatDto>();
                cfg.CreateMap<LogBookDto, DataAccess.LogBook>();
                cfg.CreateMap<DataAccess.LogBook, LogBookDto>();
                cfg.CreateMap<MemberDto, Member>();
                cfg.CreateMap<Member, MemberDto>();
            }).CreateMapper();
        }
    }
}
