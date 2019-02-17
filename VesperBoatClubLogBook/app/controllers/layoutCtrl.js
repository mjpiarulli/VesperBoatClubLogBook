(function () {
    "use strict";

    angular
        .module("app")
        .controller("layoutCtrl", [function () {
            var vm = this;

            vm.currentYear = new Date().getFullYear();
            vm.title = "PENN AC Log Book";
            vm.miniLogoText = "PAC";
            vm.logoText = "Penn AC";
            vm.footerCopyrightText = "Penn AC Rowing Association";
            vm.css = "skin-pacra.min.css";
            vm.cssSkinClass = "skin-pacra";
        }]);
})();