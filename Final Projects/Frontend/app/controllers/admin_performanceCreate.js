app.controller("admin_PerformanceCreate",function($scope,ajax,$location){

    $scope.AddPerformance = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Performance/Add",p,
       function(resp){
           $location.path("/PerformanceRead");
       },
       function(err){});

     };
});
