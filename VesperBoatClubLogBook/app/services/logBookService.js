(function() {
    "use strict";

    angular
        .module("app")
        .service("logBookService", function($http) {
            this.getLogBookById = function(id) {
                return $http.get("api/logBook/loadLogBookById?id=" + id);
            };

            this.getClubMileageYearToDate = function() {
                return $http.get("api/logbook/loadclubmileageyeartodate");
            };

            this.getClubMileageLastYearToDate = function () {
                return $http.get("api/logbook/loadclubmileagelastyeartodate");
            };

            this.searchLogBook = function(searchParams) {
                return $http.post("api/logbook/searchlogbook", searchParams);
            };

            this.addNewLog = function(log) {
                return $http.post("api/logBook/addNewLog", log);
            };

            this.editLog = function(log) {
                return $http.post("api/logBook/editLog", log);
            };
        });
})();