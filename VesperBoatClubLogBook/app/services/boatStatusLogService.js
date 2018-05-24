(function() {
    "use strict";

    angular
        .module("app")
        .service("boatStatusLogService", function($http) {
            this.getDamagedBoatList = function () {
                return $http.get("api/boatStatusLog/loadDamagedBoatList");
            };

            this.getBoatStatusLogSearch = function (searchParams) {
                return $http.post("/api/boatStatusLog/loadBoatStatusLogSearch", searchParams);
            };
        });
})();