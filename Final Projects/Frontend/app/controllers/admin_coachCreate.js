app.controller("admin_coachCreate",function($scope,ajax,$location){

    ajax.get("https://localhost:44368/api/Salary/Details",
    function(resp){
      $scope.salary = resp.data;

    },

    function(err){

    });

    $scope.AddCoach = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Coach/Add",p,
       function(resp){
           $location.path("/coach_f");
       },
       function(err){});

     };
});
