var MusicPortfolioApp = angular.module('MusicPortfolioApp', ['ngRoute']).
    controller('LandingPageController', LandingPageController).
    controller('LoginController', LoginController).
    factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor).
    factory('LoginFactory', LoginFactory).
    factory('RegistrationFactory', RegistrationFactory);
    //config(navConfigFunc);

var navConfigFunc = function ($routeProvider, $httpProvider, $locationProvider) {

    $locationProvider.hashPrefix('!').html5Mode(true);

    $routeProvider.
        when('/latest', {
            templateUrl: 'routes/latest',
            //controller: 'latestController'
        }).
        when('/music', {
            templateUrl: 'routes/music',
            //controller: 'musicController'
        }).
        when('/shop', {
            templateUrl: 'routes/shop'
            //controller: 'shopController'
        }).
        when('/contact', {
            templateUrl: 'routes/contact',
            //controller: 'contactController'
        }).
        when('/about', {
            templateUrl: 'routes/about',
            //controller: 'aboutController'
        }).
        when('/login?returnUrl', {
            templateUrl: 'Account/Login',
            controller: LoginController
        }).
        when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        }).
        when('/register', {
            templateUrl: '/Account/Register',
            controller: RegisterController
        }).
        otherwise({
            redirectTo: '/'
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

}

navConfigFunc.$inject = ['$routeProvider', '$httpProvider', '$locationProvider'];

MusicPortfolioApp.config(navConfigFunc);