productModule.controller('productListCtrl', ['$scope', 'productDataSvc', function ($scope, productDataSvc) {
    productDataSvc.getAll().success(function (data) {
        $scope.products = data;
    });
}]);