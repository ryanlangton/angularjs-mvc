productModule.factory('productDataSvc', ['$http', function ($http) {
    return {
        getAll: function () {
            return $http.get('/api/product');
        },
        get: function (id) {
            return $http.get('/api/product/' + id);
        }
    }
}]);