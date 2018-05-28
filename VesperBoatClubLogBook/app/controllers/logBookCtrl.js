(function () {
    "use strict";

    angular
        .module("app")
        .controller("logBookCtrl", ["logBookService", "boatService", "memberService", "boatTypeService", "reportService",
            function (logBookService, boatService, memberService, boatTypeService, reportService) {

                var vm = this;
                vm.log = {};
                vm.log.Boatings = [];
                vm.submitAttempted = false;


                reportService.getMileageLeaderReport().then(function (response) {
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

                boatTypeService.getBoatTypesOrderedBySeats().then(function (response) {
                    vm.boatTypes = response.data;
                }, function () {
                    console.log("Error in getBoatTypesOrderedBySeats()");
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
                var resetLogbookForm = function () {
                    vm.log = {};
                    vm.log.Boatings = [];
                    vm.selectedBoatType = null;
                    vm.submitAttempted = false;
                    setTimeout(function () { angular.element("#boatName").selectpicker("refresh"); }, 50);
                    setTimeout(function () { angular.element(".rowerName").selectpicker("refresh"); }, 50);
                    vm.logBookForm.$setPristine();
                    vm.logBookForm.$setUntouched();
                };
                vm.addEditLog = function (log) {
                    if (log.LogBookId === undefined) {
                        logBookService.addNewLog(log).then(function (response) {
                            toastr.success("New log added successfully");
                            resetLogbookForm();
                        });
                    }
                }

                vm.getSeatNameByIndex = function (index) {
                    if (vm.selectedBoatType === undefined || vm.selectedBoatType === null)
                        return "Bow";

                    var lastSeat = (vm.selectedBoatType.Seats - 1 === index);
                    var hasCox = vm.selectedBoatType.HasCox;
                    if (hasCox && lastSeat)
                        return "Cox";
                    else if (index === 0)
                        return "Bow";
                    else
                        return (index + 1).toString();
                };


            }]);
})();