(function () {
    'use strict';

    angular
        .module('libraryModule')
        .controller('dashboardController', dashboardController);

    dashboardController.$inject = ['$scope','$state'];

    function dashboardController($scope,$state) {
        
        $scope.books = {};


        $scope.isAdmin = false;

        $scope.addBook = function () {
            $state.go("BookCreate");
        }

        $scope.dashboard = function () {
            $state.go("mainDashboard");
        }

        $scope.search = function () {
            $state.go("search");
        }

        $scope.myBooks = function () {
            $state.go("MyBooks");
        }

        $scope.rent = function () {
            $state.go("Rent");
        }

        $scope.myAccount = function () {
            $state.go("Account");
        }

    }
})();
