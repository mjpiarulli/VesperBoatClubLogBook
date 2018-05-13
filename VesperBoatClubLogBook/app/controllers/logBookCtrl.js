(function () {
    "use strict";

    angular
        .module("app")
        .controller("logBookCtrl", ["logBookService", "boatService", "memberService", "boatTypeService", "reportService",
            function (logBookService, boatService, memberService, boatTypeService, reportService) {

                var vm = this;

                reportService.getMileageLeaderReport().then(function(response) {
                    vm.mileageLeaderReport = response.data;
                }, function () {
                    console.log("Error in getMileageLeaderReport()");
                });

                logBookService.getClubMileageYearToDate().then(function (response) {
                    vm.totalClubMileageYearToDate = response.data;
                }, function () {
                    console.log("Error in getClubMileageYearToDate()");
                });
                logBookService.getClubMileageLastYearToDate().then(function (response) {
                    vm.totalClubMileageLastYearToDate = response.data;
                }, function () {
                    console.log("Error in getClubMileageLastYearToDate()");
                });

                boatService.getBoatList().then(function (response) {
                    vm.boats = response.data;

                    setTimeout(function () { angular.element("#boatName").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getBoatList()");
                });

                memberService.getMemberList().then(function (response) {
                    vm.members = response.data;

                    setTimeout(function () { angular.element(".rowerName").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getMemberList()");
                });

                boatTypeService.getBoatTypesBySeats().then(function (response) {
                    vm.boatTypes = response.data;
                }, function () {
                    console.log("Error in getBoatTypesBySeats()");
                });

                vm.loadBoatsByType = function () {
                    boatService.getBoatsByBoatType(vm.selectedBoatType.Type).then(function (response) {
                        vm.boats = response.data;

                        setTimeout(function () { angular.element("#boatName").selectpicker("refresh"); }, 50);
                        setTimeout(function () { angular.element(".rowerName").selectpicker("refresh"); }, 50);
                    }, function () {
                        console.log("Error in getBoatsByBoatType()");
                    });
                };

                vm.getSeatNameByIndex = function (index) {
                    if (vm.selectedBoatType === undefined)
                        return "Bow";

                    var lastSeat = (vm.selectedBoatType.Seats - 1 == index);
                    var hasCox = vm.selectedBoatType.HasCox;
                    if (hasCox && lastSeat)
                        return "Cox";
                    else if (index == 0)
                        return "Bow";
                    else
                        return (index + 1).toString();
                };
            }]);
})();