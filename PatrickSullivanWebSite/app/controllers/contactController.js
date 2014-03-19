(function (app) {

    var contactController = function ($scope, $http) {

        // create a blank object to hold our form information
        // $scope will allow this to pass between controller and view
        $scope.formData = {};

        // process the form
        $scope.processForm = function () {

            $http.post('/api/contact', JSON.stringify($scope.formData), { headers: { 'Content-Type': 'application/json; charset=utf-8' } })
            .success(function (data) { })
            .error(function (data) { });

        };

    };

    app.controller("contactController", ["$scope","$http", contactController]);

}(angular.module("app")));