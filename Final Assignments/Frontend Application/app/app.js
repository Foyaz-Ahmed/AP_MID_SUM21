var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/Dashboard",{
       templateUrl: "views/pages/Dashboard.html",
       controller: 'Dashboard'
    })
    .when("/AddProduct",{

	     templateUrl : "views/pages/AddProduct.html",
	     controller : 'addproduct'
     })
     .when("/Products",{

	     templateUrl : "views/pages/Products.html",
	     controller : 'Products'
     })
     .when("/Orders",{

	      templateUrl : "views/pages/Orders.html",
	      controller : 'Orders'

	    })
      .when("/Categories",{

	       templateUrl : "views/pages/Categories.html",
	       controller : 'categories'

	      })
        .when("/AddCategory",{

	        templateUrl : "views/pages/AddCategories.html",
	        controller : 'addcategory'

	       })
         .when("/Orders",{

           templateUrl : "views/pages/Orders.html",
           controller : 'OrderDetails'

         })
         .when("/All/Orders",{

           templateUrl : "views/pages/ShowOrders.html",
           controller:   'ShowOrders'
         })
         .when("/Details/:id",{
	          templateUrl : "views/pages/Details.html",
	          controller : 'details'

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
