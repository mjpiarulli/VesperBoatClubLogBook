using System.Data.Entity;
using System.Linq;
using DataAccess.Entity;
using Vesper.LogBook.Common;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class BoatStatusLogRepository : GenericEntityRepository<BoatStatusLog, int>, IBoatStatusLogRepository
    {
        public BoatStatusLogRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<BoatStatusLog> Search(BoatStatusLogSearchParameter search)
        {
            var query = Context.Set<BoatStatusLog>().AsQueryable();

            if (!string.IsNullOrEmpty(search.BoatName))
                query = query.Where(bsl => bsl.BoatName.Contains(search.BoatName));
            if (search.RemovalOfServiceStartDate.HasValue)
                query = query.Where(bsl => bsl.RemovalOfServiceDate.HasValue && bsl.RemovalOfServiceDate.Value >= search.RemovalOfServiceStartDate.Value);
            if (search.RemovalOfServiceEndDate.HasValue)
                query = query.Where(bsl => bsl.RemovalOfServiceDate.HasValue && bsl.RemovalOfServiceDate.Value <= search.RemovalOfServiceEndDate.Value);
            if (!string.IsNullOrEmpty(search.Comments))
                query = query.Where(bsl => bsl.Comments.Contains(search.Comments));
            if (search.ReturnToServiceStartDate.HasValue)
                query = query.Where(bsl => bsl.ReturnToServiceDate.HasValue && bsl.ReturnToServiceDate.Value >= search.ReturnToServiceStartDate.Value);
            if (search.ReturnToServiceEndDate.HasValue)
                query = query.Where(bsl => bsl.ReturnToServiceDate.HasValue && bsl.ReturnToServiceDate.Value <= search.ReturnToServiceEndDate.Value);
            if (!string.IsNullOrEmpty(search.CommentOnReturn))
                query = query.Where(bsl => bsl.CommentOnReturn.Contains(search.CommentOnReturn));

            return query;
        }
    }
}
