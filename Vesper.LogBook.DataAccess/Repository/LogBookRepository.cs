using System.Data.Entity;
using System.Linq;
using DataAccess.Entity;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class LogBookRepository : GenericEntityRepository<LogBook, int>, ILogBookRepository
    {
        public LogBookRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<LogBook> Search(LogBookSearchParameter param)
        {
            var query = Context.Set<LogBook>().AsQueryable();
            if (param.StartDate.HasValue)
                query = query.Where(lb => lb.Date >= param.StartDate.Value);
            if (param.EndDate.HasValue)
                query = query.Where(lb => lb.Date <= param.EndDate.Value);
            if (!string.IsNullOrEmpty(param.BoatName))
                query = query.Where(lb => lb.BoatName == param.BoatName);
            if (!string.IsNullOrEmpty(param.BoatType))
                query = query.Where(lb => lb.BoatType == param.BoatType);
            if (param.MemberId.HasValue)
                query = query.Where(lb => lb.Boatings.Any(b => b.MemberId == param.MemberId.Value));
            if (!string.IsNullOrEmpty(param.Comment))
                query = query.Where(lb => lb.Comment.Contains(param.Comment));

            return query;
        }
    }
}
