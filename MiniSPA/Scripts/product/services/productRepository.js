productModule.factory('productRepository', ['$resource', function ($resource) {
    var resource = $resource('/api/product/:id');
    return {
        query: function () {
            return resource.query();
        },
        get: function (id) {
            return resource.get({ id: id });
        }
    }
}]);