using System.Configuration;
using System.Web.Http;
using Vesper.Logbook.LogBookServiceContract;
using Vesper.LogBook.LogBookService;

namespace VesperBoatClubLogBook.WebApiControllers
{
    public class WebApiBaseController : ApiController
    {
        protected readonly IVesperLogBookService VesperLogBookService;

        public WebApiBaseController()
        {
            var logBookConnectionString = ConfigurationManager.ConnectionStrings["VesperLogBookEntities"].ConnectionString;
            VesperLogBookService = new VesperLogBookService(logBookConnectionString);
        }
    }
}