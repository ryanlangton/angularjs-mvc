productModule.controller('productListCtrl', ['$scope', 'productRepository', function ($scope, productRepository) {
    $scope.products = productRepository.query();
}]);