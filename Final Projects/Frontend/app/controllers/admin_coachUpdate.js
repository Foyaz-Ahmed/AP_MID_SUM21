app.controller("admin_coachUpdate",function($scope,$http,ajax, $routeParams,$location){
  var id = $routeParams.id;


  ajax.get("https://localhost:44368/api/Coach/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateCoach = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/CoachEdit/"+id,p,
       function(resp){
           $location.path("/coach_f");
       },
       function(err){});

     };
});
