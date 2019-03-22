(function () {
    "use strict";

    angular
        .module("app")
        .service("velocityService", function ($http) {
            this.convertMetersPerSecondToMilesPerHour = function (ms) {
                var mph = Math.round(ms * 2.24);

                return mph;
            };
        });
})();