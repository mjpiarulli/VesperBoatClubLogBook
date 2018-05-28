using System;
using System.Collections.Generic;
using System.Web.Http;
using Vesper.LogBook.Common;

namespace VesperBoatClubLogBook.WebApiControllers
{
    [RoutePrefix("api/logbook")]
    public class LogBookWebApiController : WebApiBaseController
    {
        [Route("loadclubmileageyeartodate")]
        [HttpGet]
        public int LoadClubMileageYearToDate()
        {
            var mileage = VesperLogBookService.GetClubMileageYearToDate(DateTime.Now);

            return mileage;
        }

        [Route("loadclubmileagelastyeartodate")]
        [HttpGet]
        public int LoadClubMileageLastYearToDate()
        {
            var mileage = VesperLogBookService.GetClubMileageYearToDate(DateTime.Now.AddYears(-1));

            return mileage;
        }

        [Route("SearchLogBook")]
        [HttpPost]
        public List<LogBookDto> SearchLogBook(LogBookSearchParameter param)
        {
            var logBooks = VesperLogBookService.SearchLogBook(param);

            return logBooks;
        }

        [Route("AddNewLog")]
        [HttpPost]
        public LogBookDto AddNewLog(LogBookDto dto)
        {
            var newLog = VesperLogBookService.AddNewLog(dto);

            return newLog;
        }
    }
}