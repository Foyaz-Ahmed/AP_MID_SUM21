app.controller("admin_fixtureUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Fixture/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateFixture = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Fixture/Edit/"+id,p,
       function(resp){
           $location.path("/admin_fixtureRead");
       },
       function(err){});

     };
});
