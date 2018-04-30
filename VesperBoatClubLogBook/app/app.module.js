(function () {
    'use strict';

    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {
        var templateUrlBase = "app/views/";
        var logBookTemplateUrlBase = templateUrlBase + "logBook/";
        var memberListTemplateUrlBase = templateUrlBase + "memberList/"
        var fleetListTemplateUrlBase = templateUrlBase + "fleetList/"
        var reportsTemplateUrlBase = templateUrlBase + "reports/"

        $routeProvider
            .when("/",
            {
                templateUrl: logBookTemplateUrlBase + "logBook.html",
                controller: "logBookCtrl as vm"
            })
            .when("/logbook",
            {
                templateUrl: logBookTemplateUrlBase + "logBook.html",
                controller: "logBookCtrl as vm"
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
            .when("/reports/equipmentusage",
            {
                templateUrl: reportsTemplateUrlBase + "equipmentUsage.html",
                controller: "reportsCtrl as vm"
            })
            ;
    }]);
})();