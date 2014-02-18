(function (app) {

    var baseUrl = "/api/links";

    var linksService = function ($http) {
        var linksFactory = {};
        linksFactory.getLinks = function () {
            return $http.get(baseUrl);
            
        };

        linksFactory.selectLink = function (id) {
            //
            // $http.put("/flights/select/3", id)
            //
            return true;
        };
        return linksFactory;
    };

    app.factory("linksService", ["$http", linksService]);


}(angular.module("app")));