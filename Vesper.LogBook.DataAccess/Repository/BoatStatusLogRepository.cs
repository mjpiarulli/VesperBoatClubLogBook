using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class BoatStatusLogRepository : GenericEntityRepository<BoatStatusLog, int>, IBoatStatusLogRepository
    {
        public BoatStatusLogRepository(DbContext context) : base(context)
        {
        }
    }
}
