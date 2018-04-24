using System.Data.Entity;
using DataAccess;
using Vesper.LogBook.DataAccess;
using Vesper.LogBook.DataAccess.Interface;
using Vesper.LogBook.DataAccess.Repository;

namespace Vesper.LogBook.LogBookService
{
    public class LogBookUnitOfWork : UnitOfWorkBase
    {
        public IMemberRepository MemberRepository;

        private readonly DbContext _context;

        public LogBookUnitOfWork(string entityConnectionString)
        {
            _context = new VesperLogBookEntities(entityConnectionString);

            MemberRepository = new MemberRepository(_context);
        }

        public override bool Save()
        {
            _context.SaveChanges();

            return true;
        }
    }
}
