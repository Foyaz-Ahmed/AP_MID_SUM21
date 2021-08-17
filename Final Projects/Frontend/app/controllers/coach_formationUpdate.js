app.controller("coach_formationUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Formation/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateFormation = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Formation/Edit/"+id,p,
       function(resp){
           $location.path("/coach_formationRead");
       },
       function(err){});

     };
});
