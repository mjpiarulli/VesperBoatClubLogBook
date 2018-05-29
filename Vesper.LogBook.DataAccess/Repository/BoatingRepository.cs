using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class BoatingRepository : GenericEntityRepository<Boating, int>, IBoatingRepository
    {
        public BoatingRepository(DbContext context) : base(context)
        {
        }
    }
}
