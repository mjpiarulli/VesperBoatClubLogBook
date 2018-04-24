(function () {
    'use strict';

    angular
        .module('app')
        .controller('layoutCtrl', [function () {
            var vm = this;

            vm.currentYear = new Date().getFullYear();
        }]);
})();