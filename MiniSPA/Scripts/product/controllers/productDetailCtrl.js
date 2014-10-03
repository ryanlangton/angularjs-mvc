productModule.controller('productDetailCtrl', ['$scope', '$routeParams', 'productDataSvc', function ($scope, $routeParams, productDataSvc) {
    var id = $routeParams.id;
    productDataSvc.get(id).success(function (data) {
        $scope.product = data;
    });
}]);