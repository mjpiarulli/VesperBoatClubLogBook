using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class BoatRepository : GenericEntityRepository<Boat, int>, IBoatRepository
    {
        public BoatRepository(DbContext context) : base(context)
        {
        }
    }
}
