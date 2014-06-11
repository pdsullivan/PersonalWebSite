(function (app) {

    var loggingController = function ($scope, $http) {

        // create a blank object to hold our form information
        // $scope will allow this to pass between controller and view
        $scope.logData = {};
        // process the form
        $scope.createLogEntry = function () {
            var today = new Date();
            $scope.logData.date = today;
            //$scope.logData.message = "";
            //$scope.logData.details = "";
            $http.post('/api/logging', JSON.stringify($scope.logData), { headers: { 'Content-Type': 'application/json; charset=utf-8' } })
            .success(function (data) {
                $scope.logData = {};
            })
            .error(function (data) {
                $scope.logFail = true;
            });

        };

        //alert('init logging controller');

        $scope.init = function () {
            $scope.logData.message = "page loaded";
            $scope.logData.details = window.location.href.toString();
            $scope.createLogEntry();
        };

        $scope.init();
    };

    app.controller("loggingController", ["$scope", "$http", loggingController]);



}(angular.module("app")));