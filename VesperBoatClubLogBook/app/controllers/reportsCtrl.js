(function () {
    "use strict";

    angular
        .module("app")
        .controller("reportsCtrl", ["reportService", "boatService", "memberService", "boatStatusLogService", "boatStatusService",
            function (reportService, boatService, memberService, boatStatusLogService, boatStatusService) {
                var vm = this;

                vm.loading = false;
                vm.report = null;
                vm.equipmentReport = null;
                vm.damagedBoats = null;
                vm.boatStatusLog = null;
                vm.boatStatusLogSearchResults = null;
                vm.boats = null;
                vm.members = null;
                vm.individualMileageReport = null;
                vm.clubMileageReport = null;
                vm.boatStatuses = null;

                vm.loadEquipmentUsageReport = function (startDate, endDate) {
                    vm.loading = true;
                    reportService.getLogBookMileageAndUsageByBoatReport(startDate, endDate).then(function (response) {
                        vm.report = "app/views/reports/partials/equipmentUsageReport.html";
                        vm.equipmentReport = response.data;
                    }, function () {
                        console.log("Error in getLogBookMileageAndUsageByBoatReport()");
                    }).finally(function () {
                        vm.loading = false;
                    });
                };

                boatStatusLogService.getDamagedBoatList().then(function (response) {
                    vm.damagedBoats = response.data;
                }, function () {
                    console.log("Error in getDamagedBoatList()");
                });

                vm.showEditBoatStatusLogModal = function(boatStatusLogId) {
                    boatStatusLogService.getBoatStatusLogById(boatStatusLogId).then(function(response) {
                        vm.boatStatusLog = response.data;
                        setTimeout(function () { angular.element("#boatName").selectpicker("refresh"); }, 50);
                        setTimeout(function () { angular.element("#status").selectpicker({ liveSearching: true }); }, 50);
                        angular.element("#boat-status-log-modal").modal("show");
                    }, function() {
                        console.log("Error in getBoatStatusLogById()");
                    });
                };

                vm.addEditBoatStatusLog = function(boatStatusLog) {
                    boatStatusLogService.editBoatStatusLog(boatStatusLog).then(function() {
                        toastr.success("Successfully edited the boat status log.");
                    }, function() {
                        console.log("Error in editBoatStatusLog()");
                    });
                };

                boatStatusService.getAllBoatStatusesAlphabetical().then(function(response) {
                    vm.boatStatuses = response.data;
                }, function() {
                    console.log("Error in getAllBoatStatusesAlphabetical()");
                });

                vm.searchBoatStatusLog = function (searchParams) {
                    vm.loading = true;
                    boatStatusLogService.getBoatStatusLogSearch(searchParams).then(function (response) {
                        vm.report = "app/views/reports/partials/boatStatusLogList.html";
                        vm.boatStatusLogSearchResults = response.data;
                    }, function () {
                        console.log("Error in getBoatStatusLogSearch()");
                    }).finally(function () {
                        vm.loading = false;
                    });
                };

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

                vm.loadIndividualMileageReport = function (memberId, startDate, endDate) {
                    vm.loading = true;
                    reportService.getIndividualMileageReport(memberId, startDate, endDate).then(function (response) {
                        vm.report = "app/views/reports/partials/individualMileageReport.html";
                        vm.individualMileageReport = response.data;
                    }, function () {
                        console.log("Error in getIndividualMileageReport()");
                    }).finally(function () {
                        vm.loading = false;
                    });
                };

                vm.loadClubMileageByMemberReport = function (startDate, endDate) {
                    vm.loading = true;
                    reportService.getClubMileageByMemberReport(startDate, endDate).then(function (response) {
                        vm.report = "app/views/reports/partials/clubMileageByMemberReport.html";
                        vm.clubMileageReport = response.data;
                    }, function () {
                        console.log("Error in getClubMileageByMemberReport()")
                    }).finally(function () {
                        vm.loading = false;
                    });
                };

                vm.loadClubLogBookReport = function (startDate, endDate) {
                    vm.loading = true;
                    reportService.getClubLogBookReport(startDate, endDate).then(function (response) {
                        vm.report = "app/views/reports/partials/clubLogBookReport.html";
                        vm.clubLogBookReport = response.data;
                    }, function () {
                        console.log("Error in getClubLogBookReport()");
                    }).finally(function () {
                        vm.loading = false;
                    });
                };
            }]);
})();