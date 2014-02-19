(function (app) {

    var linksController = function ($scope, linksService, $timeout) {


        var onError = function () {
            alert("error!!");
        };

        var onLinks = function (response) {
            $scope.links = response.data;
        };


        var init = function () {
            $scope.links = linksService.getLinks().then(onLinks, onError);
        };


        init();


        
    };

    app.controller("linksController", ["$scope", "linksService", "$timeout", linksController]);

}(angular.module("app")));
