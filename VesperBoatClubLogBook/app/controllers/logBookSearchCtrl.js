(function () {
    "use strict";

    angular
        .module("app")
        .controller("logBookSearchCtrl", ["logBookService", "boatService", "memberService", "boatTypeService",
            function (logBookService, boatService, memberService, boatTypeService) {

                var vm = this;

                vm.loading = false;

                boatService.getBoatList().then(function (response) {
                    vm.boats = response.data;

                    setTimeout(function () { angular.element("#boatName").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getBoatList()");
                });

                memberService.getMemberList().then(function (response) {
                    vm.members = response.data;

                    setTimeout(function () { angular.element("#rowerName").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getMemberList()");
                });

                boatTypeService.getBoatTypesOrderedBySeats().then(function (response) {
                    vm.boatTypes = response.data;

                    setTimeout(function () { angular.element("#boatType").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getBoatTypesOrderedBySeats()");
                });

                vm.loadBoatsByType = function () {
                    boatService.getBoatsByBoatType(vm.selectedBoatType.Type).then(function (response) {
                        vm.boats = response.data;

                        setTimeout(function () { angular.element("#boatName").selectpicker("refresh"); }, 50);
                    }, function () {
                        console.log("Error in getBoatsByBoatType()");
                    });
                };

                vm.searchLogBook = function (searchParam) {
                    vm.loading = true;
                    logBookService.searchLogBook(searchParam).then(function (response) {
                        vm.logBookEntries = response.data;
                        vm.report = "app/views/logBookSearch/partials/logBookList.html";
                    }, function () {
                        console.log("Error in searchLogBook()");
                    }).finally(function () {
                        vm.loading = false;
                    });
                };
            }]);
})();