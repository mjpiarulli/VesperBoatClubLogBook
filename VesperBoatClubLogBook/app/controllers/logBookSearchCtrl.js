(function () {
    "use strict";

    angular
        .module("app")
        .controller("logBookSearchCtrl", ["logBookService", "boatService", "memberService", "boatTypeService",
            function (logBookService, boatService, memberService, boatTypeService) {

                var vm = this;

                vm.loading = false;

                boatService.getBoatList().then(function (response) {
                    vm.boats = response.data;

                    setTimeout(function () { angular.element("#boatNameSearch").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getBoatList()");
                });

                memberService.getMemberList().then(function (response) {
                    vm.members = response.data;

                    setTimeout(function () { angular.element("#rowerNameSearch").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getMemberList()");
                });

                boatTypeService.getBoatTypesOrderedBySeats().then(function (response) {
                    vm.boatTypes = response.data;

                    setTimeout(function () { angular.element("#boatTypeSearch").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getBoatTypesOrderedBySeats()");
                });

                vm.loadBoatsByType = function () {
                    vm.selectedBoatType = vm.boatTypes.filter(bt => bt.Type == vm.log.BoatType)[0];
                    boatService.getBoatsByBoatType(vm.log.BoatType).then(function (response) {
                        vm.boats = response.data;
                        setTimeout(function () { angular.element(".boatName").selectpicker("refresh"); }, 50);
                    }, function () {
                        console.log("Error in getBoatsByBoatType()");
                    });
                };

                vm.searchLogBook = function (searchParam) {
                    vm.loading = true;
                    logBookService.searchLogBook(searchParam).then(function (response) {
                        vm.logBookEntries = response.data;
                        vm.report = "app/views/logBookSearch/partials/logBookList.html";
                    }, function () {
                        console.log("Error in searchLogBook()");
                    }).finally(function () {
                        vm.loading = false;
                    });
                };

                vm.showEditLogBookModal = function(id) {
                    logBookService.getLogBookById(id).then(function(response) {
                        vm.log = response.data;
                        vm.selectedBoatType = vm.boatTypes.filter(bt => bt.Type == vm.log.BoatType)[0];
                        angular.element("#log-book-modal").modal("show");
                        setTimeout(function() {
                            angular.element(".boatType").selectpicker("refresh");
                            angular.element(".boatName").selectpicker("refresh");
                            angular.element(".rowerName").selectpicker("refresh");
                        }, 50);
                    });
                };

                vm.addEditLog = function (log) {
                    if (log.LogBookId === undefined) {
                        logBookService.addNewLog(log).then(function (response) {
                            toastr.success("New log added successfully");
                            resetLogbookForm();
                        });
                    } else {
                        logBookService.editLog(log).then(function (response) {
                            toastr.success("Log edited successfully");
                        });
                    }
                };

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
            }]);
})();