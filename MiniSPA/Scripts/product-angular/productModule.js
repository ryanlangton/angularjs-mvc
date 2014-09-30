var productModule = angular.module('productModule', []);

productModule.controller('productCtrl', function($scope, productDataSvc) {
    $scope.product = productDataSvc.product;
});