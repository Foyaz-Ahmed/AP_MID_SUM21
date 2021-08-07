var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/Home", {
        templateUrl : "views/pages/home.html",
        controller: 'home'
    })
    .when("/Contact", {
        templateUrl : "views/pages/contact.html",
          controller: 'contact'
    })
    .when("/About", {
        templateUrl : "views/pages/about.html",
        controller: 'about'
    })
	.when("/Login", {
        templateUrl : "views/pages/login.html",
        controller: 'login'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
