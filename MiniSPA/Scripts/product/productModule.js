var productModule = angular.module('productModule', ['ngRoute','angularSpinner']);

productModule.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'Templates/product-list.html',
            controller: 'productListCtrl'
        })
        .when('/:id', {
            templateUrl: 'Templates/product-detail.html',
            controller: 'productDetailCtrl'
        });
}]);