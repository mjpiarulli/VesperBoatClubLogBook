(function() {
    "use strict";

    angular
        .module("app")
        .service("riggingService", function($http) {
            this.getAllRiggingsAlphabetical = function() {
                return $http.get("api/rigging/loadAllRiggingsAlphabetical");
            };
        });
})();