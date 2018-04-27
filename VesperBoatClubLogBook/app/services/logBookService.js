(function() {
    "use strict";

    angular
        .module("app")
        .service("logBookService", function($http) {
            this.getClubMileageYearToDate = function() {
                return $http.get("api/logbook/loadclubmileageyeartodate");
            };

            this.getClubMileageLastYearToDate = function () {
                return $http.get("api/logbook/loadclubmileagelastyeartodate");
            };
        });
})();