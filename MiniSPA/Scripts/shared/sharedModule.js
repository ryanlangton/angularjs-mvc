var sharedModule = angular.module('sharedModule', []);

sharedModule.factory('userSvc', function($resource) {
    return {
        user: function() {
            return $resource('/api/role');
        }
    }
});