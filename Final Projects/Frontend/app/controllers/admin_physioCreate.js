app.controller("admin_physioCreate",function($scope,ajax,$location){

    ajax.get("https://localhost:44368/api/Salary/Details",
    function(resp){
      $scope.salary = resp.data;

    },

    function(err){

    });

    $scope.AddPhysio = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Physio/Add",p,
       function(resp){
           $location.path("/admin_physioRead");
       },
       function(err){});

     };
});
