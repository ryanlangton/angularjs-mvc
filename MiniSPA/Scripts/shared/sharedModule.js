var sharedModule = angular.module('sharedModule', []);

sharedModule.controller('sharedModule', function ($scope, cartSvc) {
    $scope.cart = cartSvc.cart;
});

sharedModule.factory('cartSvc', function () {
    var cart = {
        products: []
    }

    return {
        cart: cart
    }
})