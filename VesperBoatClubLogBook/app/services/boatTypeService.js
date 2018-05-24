(function () {
    'use strict';

    angular
        .module('app')
        .service('boatTypeService', function ($http) {
            this.getBoatTypesOrderedBySeats = function () {
                return $http.get("api/boattype/loadallboattypesorderedbyseats");
            };
        });
})();