app.controller("coach_formationCreate",function($scope,ajax,$location){

    ajax.get("https://localhost:44368/api/Formation",
    function(resp){
      $scope.type = resp.data;

    },

    function(err){

    });

    $scope.AddFormation = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Formation/Add",p,
       function(resp){
           $location.path("/coach_formationRead");
       },
       function(err){});

     };
});
