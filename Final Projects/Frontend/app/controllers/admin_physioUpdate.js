app.controller("admin_physioUpdate",function($scope,$http,ajax, $routeParams,$location){
  var id = $routeParams.id;


  ajax.get("https://localhost:44368/api/Physio/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdatePhysio = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Physio/Edit/"+id,p,
       function(resp){
           $location.path("/admin_physioRead");
       },
       function(err){});

     };
});
