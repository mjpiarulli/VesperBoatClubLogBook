﻿(function () {
    "use strict";

    angular
        .module("app")
        .controller("memberListCtrl", ["memberService", function (memberService) {
            var vm = this;

            var getMemberList = function() {
                memberService.getMemberList().then(function (response) {
                    vm.members = response.data;
                }, function () {
                    console.log("Error in getMemberList()");
                });
            };
            getMemberList();

            vm.showNewMemberModal = function() {
                angular.element(".add-member-modal").modal("show");
            };

            vm.addNewMember = function(member) {
                memberService.addNewMember(member).then(function(response) {
                    if (response.data.MemberId === 0) {
                        toastr.error("Error adding new member.");
                    } else {
                        toastr.success("Successfully added new member");
                        vm.Member = null;
                        getMemberList();
                    }
                }, function() {
                    console.log("Error in addNewMember()");
                });
            };
        }]);
})();