(function () {
    "use strict";

    angular
        .module('app')
        .directive('initBootstrapSelect', function () {
            return function (scope, element, attrs) {
                if (scope.$last) {
                    angular.element(".selectpicker").selectpicker({ liveSearch: true });
                }
            };
        });
})()
