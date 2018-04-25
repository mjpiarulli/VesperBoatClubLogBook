using AutoMapper;
using DataAccess;
using Vesper.Logbook.LogBookServiceContract;

namespace Vesper.LogBook.LogBookService
{
    public partial class LogBookService : ILogBookService
    {
        private readonly IMapper _mapper;
        private readonly UowHelper<LogBookUnitOfWork> _uow;

        public LogBookService()
        {
            _mapper = AutomapperBootstrapper.MapLogBook();
        }

        public LogBookService(string entityConnectionString) : this()
        {
            _uow = new UowHelper<LogBookUnitOfWork>(() => new LogBookUnitOfWork(entityConnectionString));
        }
    }
}
