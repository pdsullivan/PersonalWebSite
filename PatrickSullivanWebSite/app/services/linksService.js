(function (app) {

    var baseUrl = "/api/links";

    var linksService = function ($http) {
        var linksFactory = {};
        linksFactory.getLinks = function () {
            return $http.get(baseUrl);
            
        };

        linksFactory.selectLink = function (id) {

            return true;
        };
        return linksFactory;
    };

    app.factory("linksService", ["$http", linksService]);


}(angular.module("app")));