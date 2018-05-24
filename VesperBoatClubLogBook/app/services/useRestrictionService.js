(function() {
    "use strict";

    angular
        .module("app")
        .service("useRestrictionService", function($http) {
            this.getAllUseRestrictionsAlphabetical = function() {
                return $http.get("api/useRestriction/loadAllUseRestrictionsAlphabetical");
            };
        });
})();