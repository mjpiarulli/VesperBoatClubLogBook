(function () {
    'use strict';

    angular
        .module('app')
        .service('memberService', function ($http) {
            this.getMemberList = function() {
                return $http.get("api/member/loadmemberlist");
            };

            this.addNewMember = function(member) {
                return $http.post("api/member/addnewmember", member);
            };
        });
})();