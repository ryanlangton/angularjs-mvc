productModule.controller('productDetailCtrl', ['$scope', '$routeParams', 'productRepository', function ($scope, $routeParams, productRepository) {
    $scope.product = productRepository.get($routeParams.id);
}]);