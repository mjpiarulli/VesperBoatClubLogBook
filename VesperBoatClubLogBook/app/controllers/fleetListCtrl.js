(function () {
    "use strict";

    angular
        .module("app")
        .controller("fleetListCtrl", ["boatService", function (boatService) {
            var vm = this;

            boatService.getBoatList().then(function (response) {
                vm.fleet = response.data;
            }, function () {
                console.log("Error in getFleetList()");
            });

            vm.addNewBoat = function (newBoat) {
                boatService.addNewBoat(newBoat).then(function (response) {
                    if (response.data.BoatId != 0) {
                        toastr.success("Successfully added new boat to the fleet");
                    } else {
                        toastr.error("Error adding new boat to fleet.");
                    }
                }, function () {
                    console.log("Error in addNewBoat()");
                });
            };
        }]);
})();