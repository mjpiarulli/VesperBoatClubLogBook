(function () {
    'use strict';

    angular
        .module('app')
        .service('reportService', function ($http) {
            this.loadLogBookMileageAndUsageByBoatReport = function (startDate, endDate) {
                return $http.get("api/report/loadlogbookmileageandusagebyboatreport?startDate=" + startDate + "&endDate=" + endDate);
            };
        });
})();