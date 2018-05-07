(function () {
    'use strict';

    angular
        .module('app')
        .service('boatService', function ($http) {
            this.getBoatList = function () {
                return $http.get("api/boat/loadboatlist");
            };

            this.getBoatsByBoatType = function (boatType) {
                var uri = "api/boat/loadboatsbyboattype?boatType=" + encodeURIComponent(boatType);
                return $http.get(uri);
            }
        });
})();