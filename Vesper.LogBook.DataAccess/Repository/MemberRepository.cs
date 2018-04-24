using System.Data.Entity;
using DataAccess.Entity;
using Vesper.LogBook.DataAccess.Interface;

namespace Vesper.LogBook.DataAccess.Repository
{
    public class MemberRepository : GenericEntityRepository<Member, int>, IMemberRepository
    {
        public MemberRepository(DbContext context) : base(context)
        {
        }
    }
}
