app.controller("admin_performanceUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Performance/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdatePerformance = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/PerformanceEdit/"+id,p,
       function(resp){
           $location.path("/PerformanceRead");
       },
       function(err){});

     };
});
