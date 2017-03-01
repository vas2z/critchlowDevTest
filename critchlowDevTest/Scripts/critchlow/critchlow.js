var app = angular.module('myApp', []);
app.controller('HomeCtrl', ['$scope', '$http', function ($scope, $http) {
    $scope.loaded = false;
    $http({
        method: 'POST',
        url: 'Home/GetProducts'
    })
    .then(function (response) {
        $scope.loaded = true;
        $scope.products = response.data.products;
    }, function (error) {
        console.log(error);
    });
}])

app.controller('ProductCtrl', ['$scope', '$http', '$location', function ($scope, $http, $location) {
    $scope.message = "Product Details";
    $scope.loaded = false;
    $scope.purchase = {
        quantity: 1
    };

    $scope.confirmPurchase = function (number, name) {
        window.alert(number + " items of " + name + " have been successfully added to your cart.");
        document.location.href = "/";
    };

    $http({
        method: 'POST',
        url: 'GetProductDetails?Name=' + $location.hash(),
    })
    .then(function (response) {
        $scope.loaded = true;
        $scope.product = response.data.product;
    }, function (error) {
        console.log(error);
    });
}]);

function test(number, name) {
    window.alert(number + " items of " + name + " have been successfully added to your cart.");
    document.location.href = "/";
}