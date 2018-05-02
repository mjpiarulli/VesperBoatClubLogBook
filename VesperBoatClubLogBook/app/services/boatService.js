(function () {
    'use strict';

    angular
        .module('app')
        .service('boatService', function ($http) {
            this.getBoatList = function () {
                return $http.get("api/boat/loadboatlist");
            };
        });
})();