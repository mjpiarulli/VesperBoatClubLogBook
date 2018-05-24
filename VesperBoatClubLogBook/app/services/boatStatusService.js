(function () {
    "use strict";

    angular
        .module("app")
        .service("boatStatusService", function ($http) {
            this.getAllBoatStatusesAlphabetical = function () {
                return $http.get("api/boatstatus/loadAllBoatStatusesAlphabetical");
            };
        });
})();