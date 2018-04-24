(function () {
    'use strict';

    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {
        var templateUrlBase = "app/views/";
        var homeTemplateUrlBase = templateUrlBase + "home/";
        var memberListTemplateUrlBase = templateUrlBase + "memberList/"

        $routeProvider
            .when("/",
            {
                templateUrl: homeTemplateUrlBase + "home.html",
                controller: "homeCtrl as vm"
            })
            .when("/home",
            {
                templateUrl: homeTemplateUrlBase + "home.html",
                controller: "homeCtrl as vm"
            })
            .when("/memberlist",
            {
                templateUrl: memberListTemplateUrlBase + "memberList.html",
                controller: "memberListCtrl as vm"
            })
            //.when("/api/memberwebapi/getmemberlist",
            //{
                        
            //    })

            ;
    }]);
})();