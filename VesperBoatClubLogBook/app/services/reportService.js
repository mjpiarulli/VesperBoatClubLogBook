(function () {
    "use strict";

    angular
        .module("app")
        .service("reportService", function ($http) {
            this.getLogBookMileageAndUsageByBoatReport = function (startDate, endDate) {
                return $http.get("api/report/loadlogbookmileageandusagebyboatreport?startDate=" + startDate + "&endDate=" + endDate);
            };

            this.getBoatsCheckedOutReport = function() {
                return $http.get("api/report/LoadBoatsCheckedOutReport");
            };

            this.getMileageLeaderReport = function() {
                return $http.get("api/report/LoadMileageLeaderReport");
            };

            this.getIndividualMileageReport = function(memberId, startDate, endDate) {
                return $http.get("api/report/LoadIndividualMileageReport?memberId=" + memberId + "&startDate=" + startDate + "&endDate=" + endDate);
            };

            this.getClubMileageByMemberReport = function (startDate, endDate) {
                return $http.get("api/report/loadClubMileageByMemberReport?startDate=" + startDate + "&endDate=" + endDate);
            };

            this.getClubLogBookReport = function(startDate, endDate) {
                return $http.get("api/report/LoadClubLogBookReport?startDate=" + startDate + "&endDate=" + endDate);
            };
        });
})();