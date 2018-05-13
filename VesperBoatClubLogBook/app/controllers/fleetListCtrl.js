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
        }]);
})();