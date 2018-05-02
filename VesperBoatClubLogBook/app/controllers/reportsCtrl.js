(function () {
    'use strict';

    angular
        .module('app')
        .controller('reportsCtrl', ["reportService", "boatService", function (reportService, boatService) {
            var vm = this;

            vm.loadEquipmentUsageReport = function(startDate, endDate) {
                reportService.loadLogBookMileageAndUsageByBoatReport(startDate, endDate).then(function (response) {
                    vm.report = "app/views/reports/partials/equipmentUsageReport.html"
                    vm.equipmentReport = response.data;
                }, function () {
                    console.log("Error in loadLogBookMileageAndUsageByBoatReport()");
                });
            };

            reportService.loadDamagedBoatList().then(function(response) {
                vm.damagedBoats = response.data;
            });

            vm.searchBoatStatusLog = function(searchParams) {
                reportService.loadBoatStatusLogSearch(searchParams).then(function (response) {
                    vm.report = "app/views/reports/partials/boatStatusLogList.html";
                    vm.boatStatusLogSearchResults = response.data;
                });
            };

            boatService.getBoatList().then(function (response) {
                vm.boats = response.data;
            });
        }]);
})();