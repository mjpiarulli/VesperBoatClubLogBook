using AutoMapper;
using DataAccess;
using Vesper.Logbook.LogBookServiceContract;

namespace Vesper.LogBook.LogBookService
{
    public partial class VesperLogBookService : IVesperLogBookService
    {
        private readonly IMapper _mapper;
        private readonly UowHelper<VesperLogBookUnitOfWork> _uow;

        public VesperLogBookService()
        {
            _mapper = AutomapperBootstrapper.MapLogBook();
        }

        public VesperLogBookService(string entityConnectionString) : this()
        {
            _uow = new UowHelper<VesperLogBookUnitOfWork>(() => new VesperLogBookUnitOfWork(entityConnectionString));
        }
    }
}
