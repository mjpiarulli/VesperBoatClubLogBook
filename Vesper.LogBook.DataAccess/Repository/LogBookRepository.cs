using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class LogBookRepository : GenericEntityRepository<LogBook, int>, ILogBookRepository
    {
        public LogBookRepository(DbContext context) : base(context)
        {
        }
    }
}
