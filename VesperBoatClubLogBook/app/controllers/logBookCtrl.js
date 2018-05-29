(function () {
    "use strict";

    angular
        .module("app")
        .controller("logBookCtrl", ["logBookService", "boatService", "memberService", "boatTypeService", "reportService",
            function (logBookService, boatService, memberService, boatTypeService, reportService) {

                var vm = this;

                var getSeatNameByIndex = function (index) {
                    if (vm.selectedBoatType === undefined || vm.selectedBoatType === null)
                        return "Bow";

                    var lastSeat = vm.selectedBoatType.Seats - 1 === index;
                    var hasCox = vm.selectedBoatType.HasCox;
                    if (hasCox && lastSeat)
                        return "Cox";
                    else if (index === 0)
                        return "Bow";
                    else
                        return (index + 1).toString();
                };

                var resetNewBoatings = function (seats) {
                    vm.log.Boatings = new Array(seats);
                    for (var i = 0; i < seats; i++) {
                        vm.log.Boatings[i] = {};
                        vm.log.Boatings[i].Order = i + 1;
                        vm.log.Boatings[i].Seat = getSeatNameByIndex(i);
                    }
                };

                vm.log = {};
                resetNewBoatings(1);
                vm.submitAttempted = false;

                var getMileageLeaderReport = function() {
                    reportService.getMileageLeaderReport().then(function (response) {
                        vm.mileageLeaderReport = response.data;
                    }, function () {
                        console.log("Error in getMileageLeaderReport()");
                    });
                };
                getMileageLeaderReport();

                var getClubMileageYearToDate = function() {
                    logBookService.getClubMileageYearToDate().then(function(response) {
                        vm.totalClubMileageYearToDate = response.data;
                    }, function() {
                        console.log("Error in getClubMileageYearToDate()");
                    });
                };
                getClubMileageYearToDate();

                var getClubMileageLastYearToDate = function() {
                    logBookService.getClubMileageLastYearToDate().then(function (response) {
                        vm.totalClubMileageLastYearToDate = response.data;
                    }, function () {
                        console.log("Error in getClubMileageLastYearToDate()");
                    });
                };
                getClubMileageLastYearToDate();

                boatService.getBoatList().then(function (response) {
                    vm.boats = response.data;

                    setTimeout(function () { angular.element(".boatName").selectpicker({ liveSearching: true }); }, 50);
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
                    vm.selectedBoatType = vm.boatTypes.filter(bt => bt.Type == vm.log.BoatType)[0];
                    resetNewBoatings(vm.selectedBoatType.Seats);
                    boatService.getBoatsByBoatType(vm.log.BoatType).then(function (response) {
                        vm.boats = response.data;
                        setTimeout(function() {
                            angular.element("#boatName").selectpicker("refresh");
                            angular.element(".rowerName").selectpicker("refresh");
                        }, 50);
                    }, function () {
                        console.log("Error in getBoatsByBoatType()");
                    });
                };
                var resetLogbookForm = function () {
                    angular.element("#date").datetimepicker("clear");
                    angular.element("#datetimepickerTimeOut").datetimepicker("clear");
                    angular.element("#datetimepickerTimeIn").datetimepicker("clear");
                    vm.log = {};
                    resetNewBoatings(1);
                    vm.selectedBoatType = null;
                    vm.submitAttempted = false;
                    setTimeout(function () { angular.element("#boatName").selectpicker("refresh"); }, 50);
                    setTimeout(function () { angular.element(".rowerName").selectpicker("refresh"); }, 50);
                    vm.logBookForm.$setPristine();
                    vm.logBookForm.$setUntouched();
                };
                vm.addEditLog = function(log) {
                    if (log.LogBookId === undefined) {
                        logBookService.addNewLog(log).then(function(response) {
                            toastr.success("New log added successfully");
                            resetLogbookForm();
                        });
                    } else {
                        logBookService.editLog(log).then(function(response) {
                            toastr.success("Log edited successfully");
                        });
                    }
                    getMileageLeaderReport();
                    getClubMileageYearToDate();
                    getClubMileageLastYearToDate();
                };
            }]);
})();