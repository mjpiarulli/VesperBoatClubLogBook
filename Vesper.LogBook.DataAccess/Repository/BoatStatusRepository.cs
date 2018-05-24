using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class BoatStatusRepository : GenericEntityRepository<BoatStatu, int>, IBoatStatusRepository
    {
        public BoatStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
