(function () {
    'use strict';

    angular
        .module('app')
        .service('memberService', function ($http) {
            this.getMemberList = function() {
                return $http.get("api/member/loadmemberlist")
            };
        });
})();