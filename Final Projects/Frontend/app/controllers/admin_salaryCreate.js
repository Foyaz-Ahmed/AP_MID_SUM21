app.controller("admin_salaryCreate",function($scope,ajax,$location){

    $scope.AddSalary = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Salary/Add",p,
       function(resp){
           $location.path("/admin_salaryRead");
       },
       function(err){});

     };
});
