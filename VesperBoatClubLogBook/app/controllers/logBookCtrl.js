(function () {
    'use strict';

    angular
        .module('app')
        .controller('logBookCtrl', [function () {
            var vm = this;

            vm.mileageLeaders = [
                { FirstName: "Julia", LastName: "Lonchar", Mileage: 448 },
                { FirstName: "Liz", LastName: "Euiler", Mileage: 429 },
                { FirstName: "Shannon", LastName: "Kaplan", Mileage: 422 },
                { FirstName: "Kieran", LastName: "Edwards", Mileage: 401 },
                { FirstName: "Alanna", LastName: "Fogarty", Mileage: 386 },
            ];

            vm.totalClubMileageYearToDate = 5217;
            vm.totalClubMileageLastYearToDate = 6938;
        }]);
})();