var sharedModule = angular.module('sharedModule', []);

sharedModule.service('userSvc', function($resource) {
    return {
        user: function() {
            return $resource('/api/role');
        }
    }
});