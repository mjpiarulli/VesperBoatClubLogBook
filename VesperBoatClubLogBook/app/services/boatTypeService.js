(function () {
    'use strict';

    angular
        .module('app')
        .service('boatTypeService', function ($http) {
            this.getBoatTypesBySeats = function () {
                return $http.get("api/boattype/loadallboattypesbyseats");
            };
        });
})();