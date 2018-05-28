(function() {
    "use strict";

    angular.module("app")
        .controller("reportBoatDamageCtrl", ["boatStatusLogService", "boatService", "boatStatusService",
            function(boatStatusLogService, boatService, boatStatusService) {
                var vm = this;

                vm.boatStatusLog = null;
                vm.boats = null;
                vm.boatStatuses = null;
                
                vm.addEditBoatStatusLog = function(boatStatusLog) {
                    if (boatStatusLog.BoatStatusLogId === undefined) {
                        boatStatusLogService.addNewBoatStatusLog(boatStatusLog).then(function() {
                            toastr.success("Successfully added new damage boat report.");
                        }, function() {
                            console.log("Error in addNewBoatStatusLog()");
                        });
                    } else {
                        boatStatusLogService.editBoatStatusLog(boatStatusLog).then(function() {
                            toastr.success("Successfully edited the boat status log.");
                        }, function() {
                            console.log("Error in editBoatStatusLog()");
                        });
                    }
                };

                boatService.getBoatList().then(function (response) {
                    vm.boats = response.data;
                    setTimeout(function () { angular.element("#boatName").selectpicker({ liveSearching: true }); }, 50);
                }, function () {
                    console.log("Error in getBoatList()");
                });

                boatStatusService.getAllBoatStatusesAlphabetical().then(function(response) {
                    vm.boatStatuses = response.data;
                    setTimeout(function () { angular.element("#status").selectpicker({ liveSearching: true }); }, 50);
                }, function() {
                    console.log("Error in getAllBoatStatusesAlphabetical()");
                });
            }]);
})();