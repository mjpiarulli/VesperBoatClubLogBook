using System.Data.Entity;
using DataAccess;
using Vesper.LogBook.DataAccess;
using Vesper.LogBook.DataAccess.Interface;
using Vesper.LogBook.DataAccess.Repository;

namespace Vesper.LogBook.LogBookService
{
    public class VesperLogBookUnitOfWork : UnitOfWorkBase
    {
        public readonly IMemberRepository MemberRepository;
        public readonly IBoatRepository BoatRepository;
        public readonly ILogBookRepository LogBookRepository;
        public readonly IBoatStatusLogRepository BoatStatusLogRepository;
        public readonly IBoatTypeRepository BoatTypeRepository;
        public readonly IBoatStatusRepository BoatStatusRepository;
        public readonly IRiggingRepository RiggingRepository;
        public readonly IUseRestrictionRepository UseRestrictionRepository;
        public readonly IBoatingRepository BoatingRepository;

        private readonly DbContext _context;

        public VesperLogBookUnitOfWork(string entityConnectionString)
        {
            _context = new VesperLogBookEntities(entityConnectionString);

            MemberRepository = new MemberRepository(_context);
            BoatRepository = new BoatRepository(_context);
            LogBookRepository = new LogBookRepository(_context);
            BoatStatusLogRepository = new BoatStatusLogRepository(_context);
            BoatTypeRepository = new BoatTypeRepository(_context);
            BoatStatusRepository = new BoatStatusRepository(_context);
            RiggingRepository = new RiggingRepository(_context);
            UseRestrictionRepository = new UseRestrictionRepository(_context);
            BoatingRepository = new BoatingRepository(_context);
        }

        public override bool Save()
        {
            _context.SaveChanges();

            return true;
        }
    }
}
