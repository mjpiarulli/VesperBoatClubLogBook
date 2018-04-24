(function () {
    'use strict';

    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {
        var templateUrlBase = "app/views/";
        var homeTemplateUrlBase = templateUrlBase + "home/";

        $routeProvider
            .when("/",
            {
                templateUrl: homeTemplateUrlBase + "home.html",
                controller: "homeCtrl as vm"
            })

            ;
    }]);
})();