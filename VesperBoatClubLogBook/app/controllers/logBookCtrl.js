(function () {
    'use strict';

    angular
        .module('app')
        .controller('logBookCtrl', ["logBookService", function (logBookService) {
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
        }]);
})();