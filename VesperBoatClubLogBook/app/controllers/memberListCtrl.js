(function () {
    "use strict";

    angular
        .module("app")
        .controller("memberListCtrl", ["memberService", function (memberService) {
            var vm = this;

            memberService.getMemberList().then(function (response) {
                vm.members = response.data;
            }, function () {
                console.log("Error in getMemberList()");
            });
        }]);
})();