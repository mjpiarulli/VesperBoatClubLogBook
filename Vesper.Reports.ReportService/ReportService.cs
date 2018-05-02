﻿using System;
using DataAccess;
using Vesper.Reports.Common;
using Vesper.Reports.ReportServiceContract;

namespace Vesper.Reports.ReportService
{
    public class ReportService : IReportService
    {
        private readonly UowHelper<ReportUnitOfWork> _uow;

        public ReportService(string entityConnectionString)
        {
            _uow = new UowHelper<ReportUnitOfWork>(() => new ReportUnitOfWork(entityConnectionString));
        }

        public LogBookMileageAndUsageByBoat GetLogBookMileageAndUsageByBoatReport(DateTime startDate, DateTime endDate) => _uow.Uow(uow =>
        {
            var report = uow.ReportRepository.GetLogBookMileageAndUsageByBoatReport(startDate, endDate);

            return report;
        });
    }
}