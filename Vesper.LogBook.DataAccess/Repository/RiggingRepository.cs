using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class RiggingRepository : GenericEntityRepository<Rigging, int>, IRiggingRepository
    {
        public RiggingRepository(DbContext context) : base(context)
        {
        }
    }
}
