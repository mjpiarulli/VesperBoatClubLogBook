(function () {
    'use strict';

    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {
        var templateUrlBase = "app/views/";
        var logBookTemplateUrlBase = templateUrlBase + "logBook/";
        var memberListTemplateUrlBase = templateUrlBase + "memberList/"
        var fleetListTemplateUrlBase = templateUrlBase + "fleetList/"

        $routeProvider
            .when("/",
            {
                templateUrl: logBookTemplateUrlBase + "logBook.html",
                controller: "logBookCtrl as vm"
            })
            .when("/logbook",
            {
                templateUrl: logBookTemplateUrlBase + "home.html",
                controller: "homeCtrl as vm"
            })
            .when("/memberlist",
            {
                templateUrl: memberListTemplateUrlBase + "memberList.html",
                controller: "memberListCtrl as vm"
            })
            .when("/fleetlist",
            {
                templateUrl: fleetListTemplateUrlBase + "fleetList.html",
                controller: "fleetListCtrl as vm"
            })

            ;
    }]);
})();