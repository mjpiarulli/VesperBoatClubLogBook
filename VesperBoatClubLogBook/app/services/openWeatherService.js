(function () {
    "use strict";

    angular
        .module("app")
        .service("openWeatherService", function ($http) {
            this.getCurrentWeatherConditions = function () {
                return $http.get("http://api.openweathermap.org/data/2.5/weather?q=philadelphia&APPID=3c70d05c0f1d14e6fe67c52c03c06e74");
            };
        });
})();