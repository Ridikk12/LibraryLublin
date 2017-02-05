(function () {
    'use strict';

    angular
        .module('libraryModule')
        .controller('bookController', bookController);

    bookController.$inject = ['$scope'];

    function bookController($scope) {
        $scope.books = {};
        $scope.init = function () {
            $.get("Book/GetBooks", function (result) {
                $scope.books = result;
                $scope.$apply();
            });
        }
    }
})();
