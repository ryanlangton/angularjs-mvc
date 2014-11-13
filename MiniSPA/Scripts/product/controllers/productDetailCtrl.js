productModule.controller('productDetailCtrl', ['$scope', '$location', 'productRepository', function ($scope, $location, productRepository) {
    var urlSegments = $location.absUrl().split("/");
    var id = urlSegments[urlSegments.length - 1];
    $scope.product = productRepository.get(id);
}]);