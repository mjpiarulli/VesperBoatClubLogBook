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

        private readonly DbContext _context;

        public VesperLogBookUnitOfWork(string entityConnectionString)
        {
            _context = new VesperLogBookEntities(entityConnectionString);

            MemberRepository = new MemberRepository(_context);
            BoatRepository = new BoatRepository(_context);
            LogBookRepository = new LogBookRepository(_context);
            BoatStatusLogRepository = new BoatStatusLogRepository(_context);
        }

        public override bool Save()
        {
            _context.SaveChanges();

            return true;
        }
    }
}
