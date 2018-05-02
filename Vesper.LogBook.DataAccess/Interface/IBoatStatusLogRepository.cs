using System.Linq;
using DataAccess;
using Vesper.LogBook.Common;

namespace Vesper.LogBook.DataAccess.Interface
{
    public interface IBoatStatusLogRepository : IGenericRepository<BoatStatusLog, int>
    {
        IQueryable<BoatStatusLog> Search(BoatStatusLogSearchParameter search);
    }
}
