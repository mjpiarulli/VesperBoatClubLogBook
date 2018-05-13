(function () {
    "use strict";

    angular
        .module("app")
        .service("reportService", function ($http) {
            this.getLogBookMileageAndUsageByBoatReport = function (startDate, endDate) {
                return $http.get("api/report/loadlogbookmileageandusagebyboatreport?startDate=" + startDate + "&endDate=" + endDate);
            };

            this.getDamagedBoatList = function() {
                return $http.get("api/report/LoadDamagedBoatList");
            };

            this.getBoatStatusLogSearch = function(searchParams) {
                return $http.post("/api/report/LoadBoatStatusLogSearch", searchParams);
            };

            this.getMileageLeaderReport = function() {
                return $http.get("/api/report/LoadMileageLeaderReport");
            };

            this.getIndividualMileageReport = function(memberId, startDate, endDate) {
                return $http.get("/api/report/LoadIndividualMileageReport?memberId=" + memberId + "&startDate=" + startDate + "&endDate=" + endDate);
            };
        });
})();