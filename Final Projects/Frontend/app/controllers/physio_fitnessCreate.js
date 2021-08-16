app.controller("physio_fitnessCreate",function($scope,ajax,$location){

    $scope.AddFitness = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Fitness/Add",p,
       function(resp){
           $location.path("/physio_fitnessRead");
       },
       function(err){});

     };
});
