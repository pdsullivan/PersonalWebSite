(function (app) {

    var linksController = function ($scope, linksService, $timeout) {


        $scope.links =  [
                {
                    "desc": "Podcast by Jesse Liberty",
                    "url": "https://itunes.apple.com/us/podcast/id393751871"
                },
                {
                    "desc": "9to5Mac Apple Intelligence",
                    "url": "http://9to5mac.com/"
                },
                {
                    "desc":"StackExchange Blog",
                    "url": "http://blog.stackexchange.com/"
                },
                {
                    "desc": "StackExchange Podcast",
                    "url": "http://blog.stackexchange.com/"
                }
            ];

        
    };

    app.controller("linksController", ["$scope", "linksService", "$timeout", linksController]);

}(angular.module("app")));
