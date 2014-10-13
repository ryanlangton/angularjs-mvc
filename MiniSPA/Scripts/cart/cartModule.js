var cartModule = angular.module('cartModule', []);

cartModule.controller('cartNavCtrl', function ($scope, cartSvc) {
    $scope.cart = cartSvc.cart;
});

cartModule.factory('cartSvc', function() {
    var cart = {
        products: []
    }

    return {
        cart: cart
    }
})