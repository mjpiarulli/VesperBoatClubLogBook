using System.Configuration;
using System.Web.Http;
using Vesper.Logbook.LogBookServiceContract;
using Vesper.LogBook.LogBookService;
using Vesper.Reports.ReportService;
using Vesper.Reports.ReportServiceContract;

namespace VesperBoatClubLogBook.WebApiControllers
{
    public class WebApiBaseController : ApiController
    {
        protected readonly IVesperLogBookService VesperLogBookService;
        protected readonly IReportService ReportService;

        public WebApiBaseController()
        {
            var logBookConnectionString = ConfigurationManager.ConnectionStrings["VesperLogBookEntities"].ConnectionString;

            VesperLogBookService = new VesperLogBookService(logBookConnectionString);
            ReportService = new ReportService(logBookConnectionString);
        }
    }
}