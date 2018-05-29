(function () {
    "use strict";

    angular
        .module("app")
        .controller("fleetListCtrl", ["boatService", "boatTypeService", "riggingService", "useRestrictionService", "boatStatusService",
            function (boatService, boatTypeService, riggingService, useRestrictionService, boatStatusService) {
                var vm = this;

                var getBoatList = function() {
                    boatService.getBoatList().then(function (response) {
                        vm.fleet = response.data;
                    }, function () {
                        console.log("Error in getFleetList()");
                    });
                };
                getBoatList();

                boatTypeService.getBoatTypesOrderedBySeats().then(function (response) {
                    vm.boatTypes = response.data;
                }, function () {
                    console.log("Error in getBoatTypesOrderedBySeats()");
                });

                riggingService.getAllRiggingsAlphabetical().then(function(response) {
                    vm.riggings = response.data;
                }, function() {
                    console.log("Error in getAllRiggingsAlphabetical()");
                });

                useRestrictionService.getAllUseRestrictionsAlphabetical().then(function(response) {
                    vm.useRestrictions = response.data;
                }, function() {
                    console.log("Erorr in getAllUseRestrictionsAlphabetical()");
                });

                boatStatusService.getAllBoatStatusesAlphabetical().then(function(response) {
                    vm.boatStatuses = response.data;
                }, function() {
                    console.log("Error in getAllBoatStatusesAlphabetical()");
                    });

                vm.showAddEditBoatModal = function () {
                    angular.element(".boat-modal").modal("show");
                    angular.element("#type").selectpicker({ liveSearching: true });
                    angular.element("#currentRigging").selectpicker({ liveSearching: true });
                    angular.element("#riggingAvailable").selectpicker({ liveSearching: true });
                    angular.element("#useRestrictions").selectpicker({ liveSearching: true });
                    angular.element("#status").selectpicker({ liveSearching: true });
                };

                vm.addEditBoat = function (boat) {
                    boatService.addNewBoat(boat).then(function (response) {
                        if (response.data.BoatId !== 0) {
                            toastr.success("Successfully added new boat to the fleet");
                            vm.Boat = null;
                            getBoatList();
                        } else {
                            toastr.error("Error adding new boat to fleet.");
                        }
                    }, function () {
                        console.log("Error in addNewBoat()");
                    });
                };
            }]);
})();