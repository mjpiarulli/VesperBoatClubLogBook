using System.Configuration;
using System.Web.Http;
using Vesper.Logbook.LogBookServiceContract;
using Vesper.LogBook.LogBookService;

namespace VesperBoatClubLogBook.WebApiControllers
{
    public class WebApiBaseController : ApiController
    {
        protected readonly ILogBookService LogBookService;

        public WebApiBaseController()
        {
            var logBookConnectionString = ConfigurationManager.ConnectionStrings["VesperLogBookEntities"].ConnectionString;
            LogBookService = new LogBookService(logBookConnectionString);
        }
    }
}