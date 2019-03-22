(function () {
    "use strict";

    angular
        .module("app")
        .service("temperatureService", function () {
            this.convertKelvinToFarenheit = function (kelvin) {
                var farenheit = Math.round((kelvin - 273.15) * 9 / 5 + 32)

                return farenheit;
            };
            this.convertCelciusToFarenheit = function (celcius) {
                var farenheit = Math.round(celcius * 9 / 5 + 32)

                return farenheit;
            };
        });
})();