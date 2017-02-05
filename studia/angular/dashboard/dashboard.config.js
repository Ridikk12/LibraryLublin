(function () {
    'use strict';
    angular.module("libraryModule").config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/');
        $stateProvider
            .state('mainDashboard', {
                url: '/',
                views: {
                    'menu': {
                        templateProvider: function () {
                            return $.get("Dashboard/Menu");
                        }

                    },
                    'mainContent': {
                        templateProvider: function () {
                            return $.get("Dashboard/RecentlyAdded");
                        }

                    },
                }
            })
        .state('BookCreate', {
            url: '/Book/Create',
            views: {
                'menu': {
                    templateProvider: function () {
                        return $.get("Dashboard/Menu");
                    }

                },
                'mainContent': {
                    templateProvider: function () {
                        return $.get("Book/Create");
                    }
                },
            }
        })
         .state('search', {
             url: '/Book/Search',
             views: {
                 'menu': {
                     templateProvider: function () {
                         return $.get("Dashboard/Menu");
                     }

                 },
                 'mainContent': {
                     templateProvider: function () {
                         debugger;
                         return $.get("Book/List");
                     }
                 },
             }
         });
    }

})();