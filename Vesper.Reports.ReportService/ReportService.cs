using System;
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

        public BoatsCheckedOutReport GetBoatsCheckedOutReport() => _uow.Uow(uow =>
        {
            var report = uow.ReportRepository.GetBoatsCheckedOutReport();

            return report;
        });

        public MileageLeaderReport GetMileageLeaderReport() => _uow.Uow(uow =>
        {
            var report = uow.ReportRepository.GetMileageLeaderReport();

            return report;
        });

        public IndividualMileageReport GetIndividualMileageReport(int memberId, DateTime startDate, DateTime endDate) => _uow.Uow(uow =>
        {
            var report = uow.ReportRepository.GetIndividualMileageReport(memberId, startDate, endDate);

            return report;
        });

        public ClubMileageByMemberReport GetClubMileageByMemberReport(DateTime startDate, DateTime endDate) => _uow.Uow(uow =>
        {
            var report = uow.ReportRepository.GetClubMileageByMemberReport(startDate, endDate);

            return report;
        });

        public ClubLogBookReport GetClubLogBookReport(DateTime startDate, DateTime endDate) => _uow.Uow(uow =>
        {
            var report = uow.ReportRepository.GetClubLogBookReport(startDate, endDate);

            return report;
        });
    }
}
