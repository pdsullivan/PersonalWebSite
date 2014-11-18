(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('app').factory(serviceId, ['common','$http', datacontext]);

    function datacontext(common, $http) {
        var $q = common.$q;

        var service = {
            getBlogData: getBlogData,
            getSiteData: getSiteData
        };

        return service;



        function getSiteData() {
            return $http.get('http://pdsullivan.azurewebsites.net/api/alllogging');
            
            
        }
        function getBlogData() {
            return $http.get('http://pdsullivan.azurewebsites.net/api/allbloglogging');


        }
    }
})();