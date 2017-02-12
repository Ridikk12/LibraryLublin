(function () {
    'use strict';

    angular
        .module('libraryModule')
        .controller('dashboardGird', dashboardGird);

    dashboardGird.$inject = ['$scope'];

    function dashboardGird($scope) {

        $scope.userBooks = {};
        $scope.init = function(){
            $.get("Library/UserBooks", function (result) {
                debugger;
                $scope.userBooks = result;
            });
        }
       
    }
})();
