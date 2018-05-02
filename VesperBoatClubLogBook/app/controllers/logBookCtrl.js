(function () {
    'use strict';

    angular
        .module('app')
        .controller('logBookCtrl', ["logBookService", "boatService", "memberService", function (logBookService, boatService, memberService) {
            var vm = this;

            vm.mileageLeaders = [
                { FirstName: "Julia", LastName: "Lonchar", Mileage: 448 },
                { FirstName: "Liz", LastName: "Euiler", Mileage: 429 },
                { FirstName: "Shannon", LastName: "Kaplan", Mileage: 422 },
                { FirstName: "Kieran", LastName: "Edwards", Mileage: 401 },
                { FirstName: "Alanna", LastName: "Fogarty", Mileage: 386 },
            ];

            logBookService.getClubMileageYearToDate().then(function(response) {
                vm.totalClubMileageYearToDate = response.data;
            });
            logBookService.getClubMileageLastYearToDate().then(function (response) {
                vm.totalClubMileageLastYearToDate = response.data;
            });

            boatService.getBoatList().then(function(response) {
                vm.boats = response.data;

                setTimeout(function () { angular.element("#boatName").selectpicker({ liveSearching: true }); }, 50);
            });

            memberService.getMemberList().then(function(response) {
                vm.members = response.data;

                setTimeout(function () { angular.element("#rowerName").selectpicker({ liveSearching: true }); }, 50);
            });

        }]);
})();