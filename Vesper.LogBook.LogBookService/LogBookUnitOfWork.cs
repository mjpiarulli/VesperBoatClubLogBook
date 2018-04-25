using System.Data.Entity;
using DataAccess;
using Vesper.LogBook.DataAccess;
using Vesper.LogBook.DataAccess.Interface;
using Vesper.LogBook.DataAccess.Repository;

namespace Vesper.LogBook.LogBookService
{
    public class LogBookUnitOfWork : UnitOfWorkBase
    {
        public readonly IMemberRepository MemberRepository;
        public readonly IBoatRepository BoatRepository;

        private readonly DbContext _context;

        public LogBookUnitOfWork(string entityConnectionString)
        {
            _context = new VesperLogBookEntities(entityConnectionString);

            MemberRepository = new MemberRepository(_context);
            BoatRepository = new BoatRepository(_context);
        }

        public override bool Save()
        {
            _context.SaveChanges();

            return true;
        }
    }
}
