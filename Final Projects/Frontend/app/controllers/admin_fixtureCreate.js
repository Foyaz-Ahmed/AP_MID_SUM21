app.controller("admin_fixtureCreate",function($scope,ajax,$location){

    $scope.AddFixture = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Fixture/Add",p,
       function(resp){
           $location.path("/admin_fixtureRead");
       },
       function(err){});

     };
});
