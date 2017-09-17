﻿(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider', '$locationProvider', '$qProvider',
        function ($stateProvider, $urlRouterProvider, $locationProvider, $qProvider) {
            $locationProvider.hashPrefix('');
            $urlRouterProvider.otherwise('/');
            $qProvider.errorOnUnhandledRejections(false);

            //if (abp.auth.hasPermission('Pages.Users')) {
            //    $stateProvider
            //        .state('users', {
            //            url: '/users',
            //            templateUrl: '/App/Main/views/users/index.cshtml',
            //            menu: 'Users' //Matches to name of 'Users' menu in NicVicABPNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/users');
            //}

            //if (abp.auth.hasPermission('Pages.Roles')) {
            //    $stateProvider
            //        .state('roles', {
            //            url: '/roles',
            //            templateUrl: '/App/Main/views/roles/index.cshtml',
            //            menu: 'Roles' //Matches to name of 'Tenants' menu in NicVicABPNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/roles');
            //}

            //if (abp.auth.hasPermission('Pages.Tenants')) {
            //    $stateProvider
            //        .state('tenants', {
            //            url: '/tenants',
            //            templateUrl: '/App/Main/views/tenants/index.cshtml',
            //            menu: 'Tenants' //Matches to name of 'Tenants' menu in NicVicABPNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/tenants');
            //}

            //$stateProvider
            //    .state('home', {
            //        url: '/',
            //        templateUrl: '/App/Main/views/home/home.cshtml',
            //        menu: 'Home' //Matches to name of 'Home' menu in NicVicABPNavigationProvider
            //    })
            //    .state('about', {
            //        url: '/about',
            //        templateUrl: '/App/Main/views/about/about.cshtml',
            //        menu: 'About' //Matches to name of 'About' menu in NicVicABPNavigationProvider
            //    });

            $stateProvider
                .state('tasklist', {
                    url: '/',
                    templateUrl: '/App/Main/views/task/list.cshtml',
                    menu: 'TaskList' //Matches to name of 'TaskList' menu in SimpleTaskSystemNavigationProvider
                })
                .state('newtask', {
                    url: '/new',
                    templateUrl: '/App/Main/views/task/new.cshtml',
                    menu: 'NewTask' //Matches to name of 'NewTask' menu in SimpleTaskSystemNavigationProvider
                });
        }
    ]);

})();