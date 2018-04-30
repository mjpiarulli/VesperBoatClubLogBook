using System.Data.Entity;
using DataAccess;
using Vesper.LogBook.DataAccess;
using Vesper.Reports.DataAccess.Interface;
using Vesper.Reports.DataAccess.Repository;

namespace Vesper.Reports.ReportService
{
    public class ReportUnitOfWork : UnitOfWorkBase
    {
        public readonly IReportRepository ReportRepository;

        private readonly DbContext _context;

        public ReportUnitOfWork(string entityConnectionString)
        {
            _context = new VesperLogBookEntities(entityConnectionString);

            ReportRepository = new ReportRepository(_context);
        }

        public override bool Save()
        {
            _context.SaveChanges();

            return true;
        }
    }
}
