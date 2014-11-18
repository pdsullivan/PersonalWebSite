(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['common', 'datacontext', dashboard]);

    function dashboard(common, datacontext) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.news = {
            title: 'Analytics pdsullivan',
            description: 'Hot Towel Angular is a SPA template for Angular developers.'
        };
        vm.messageCount = 0;
        vm.people = [];
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [ getBlogData(), getSiteData()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Dashboard View'); });
        }


        function getBlogData() {
            return datacontext.getBlogData().success(function (data) {
                log('Blog Data Loaded');
                return vm.blogData = data;
            });
        }
        function getSiteData() {
            return datacontext.getSiteData().success(function (data) {
                log('Site Data Loaded');
                return vm.siteData = data;
            });
        }
    }
})();