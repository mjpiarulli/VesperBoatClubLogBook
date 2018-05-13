(function () {
    "use strict";

    angular
        .module("app")
        .controller("reportsCtrl", ["reportService", "boatService", "memberService", function (reportService, boatService, memberService) {
            var vm = this;

            vm.loadEquipmentUsageReport = function(startDate, endDate) {
                reportService.getLogBookMileageAndUsageByBoatReport(startDate, endDate).then(function (response) {
                    vm.report = "app/views/reports/partials/equipmentUsageReport.html";
                    vm.equipmentReport = response.data;
                }, function () {
                    console.log("Error in getLogBookMileageAndUsageByBoatReport()");
                });
            };

            reportService.getDamagedBoatList().then(function(response) {
                vm.damagedBoats = response.data;
            }, function () {
                console.log("Error in getDamagedBoatList()");
            });

            vm.searchBoatStatusLog = function(searchParams) {
                reportService.getBoatStatusLogSearch(searchParams).then(function (response) {
                    vm.report = "app/views/reports/partials/boatStatusLogList.html";
                    vm.boatStatusLogSearchResults = response.data;
                }, function () {
                    console.log("Error in getBoatStatusLogSearch()");
                });
            };

            boatService.getBoatList().then(function (response) {
                vm.boats = response.data;
                setTimeout(function() { angular.element("#boatName").selectpicker({ liveSearching: true }); }, 50);
            }, function () {
                console.log("Error in getBoatList()");
            });

            memberService.getMemberList().then(function(response) {
                vm.members = response.data;
                setTimeout(function () { angular.element("#rowerName").selectpicker({ liveSearching: true }); }, 50);
            }, function () {
                console.log("Error in getMemberList()");
            });

            vm.loadIndividualMileageReport = function(memberId, startDate, endDate) {
                reportService.getIndividualMileageReport(memberId, startDate, endDate).then(function(response) {
                    vm.report = "app/views/reports/partials/individualMileageReport.html";
                    vm.individualMileageReport = response.data;
                }, function () {
                    console.log("Error in getIndividualMileageReport()");
                });
            };
        }]);
})();