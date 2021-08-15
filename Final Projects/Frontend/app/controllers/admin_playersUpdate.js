app.controller("admin_playersUpdate",function($scope,$http,ajax, $routeParams,$location){
  var id = $routeParams.id;


  ajax.get("https://localhost:44368/api/Player/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdatePlayers = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/PlayerEdit/"+id,p,
       function(resp){
           $location.path("/player_f");
       },
       function(err){});

     };
});
