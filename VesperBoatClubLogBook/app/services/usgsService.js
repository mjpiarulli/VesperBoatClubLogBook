(function() {
    "use strict";

    angular
        .module("app")
        .service("usgsService", function ($http) {
            this.getCurrentWaterConditions = function () {
                var url = "https://waterservices.usgs.gov/nwis/iv/?format=json&sites=01474500&parameterCd=00060,00010&siteStatus=all";
                return $http.get(url);
            };
        });
})();