using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class UseRestrictionRepository : GenericEntityRepository<UseRestriction, int>, IUseRestrictionRepository
    {
        public UseRestrictionRepository(DbContext context) : base(context)
        {
        }
    }
}
