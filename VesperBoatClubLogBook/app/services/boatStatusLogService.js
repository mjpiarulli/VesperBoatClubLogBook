(function() {
    "use strict";

    angular
        .module("app")
        .service("boatStatusLogService", function($http) {
            this.getDamagedBoatList = function () {
                return $http.get("api/boatStatusLog/loadDamagedBoatList");
            };

            this.getBoatStatusLogSearch = function (searchParams) {
                return $http.post("api/boatStatusLog/loadBoatStatusLogSearch", searchParams);
            };

            this.getBoatStatusLogById = function(id) {
                return $http.get("api/boatStatusLog/loadBoatStatusLogById?id=" + id);
            };

            this.editBoatStatusLog = function(boatStatusLog) {
                return $http.post("api/boatStatusLog/editBoatStatusLog", boatStatusLog);
            };

            this.addNewBoatStatusLog = function(boatStatusLog) {
                return $http.post("api/boatStatusLog/addNewBoatStatusLog", boatStatusLog);
            };
        });
})();