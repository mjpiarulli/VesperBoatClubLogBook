using System.Linq;
using DataAccess;
using Vesper.LogBook.Common;

namespace Vesper.LogBook.DataAccess.Interface
{
    public interface ILogBookRepository : IGenericRepository<LogBook, int>
    {
        IQueryable<LogBook> Search(LogBookSearchParameter param);
    }
}
