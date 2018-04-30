(function () {
    'use strict';

    angular
        .module('app')
        .controller('reportsCtrl', ["reportService", function (reportService) {
            var vm = this;

            vm.loadEquipmentUsageReport = function(startDate, endDate) {
                reportService.loadLogBookMileageAndUsageByBoatReport(startDate, endDate).then(function (response) {
                    vm.report = "app/views/reports/partials/equipmentUsageReport.html"
                    vm.equipmentReport = response.data;
                }, function () {
                    console.log("Error in loadLogBookMileageAndUsageByBoatReport()");
                });
            };
        }]);
})();