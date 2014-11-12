var productModule = angular.module('productModule', ['ngResource']);

productModule.service('productRepository', function ($resource) {
    var resource = $resource('/api/product/:id');
    return {
        query: function() {
            return resource.query();
        },
        get: function(id) {
            return resource.get({id: id});
        }
    }
});