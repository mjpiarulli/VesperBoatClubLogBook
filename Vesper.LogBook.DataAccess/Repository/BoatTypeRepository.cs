using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class BoatTypeRepository : GenericEntityRepository<BoatType, int>, IBoatTypeRepository
    {
        public BoatTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
