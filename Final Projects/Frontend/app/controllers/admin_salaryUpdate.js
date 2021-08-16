app.controller("admin_salaryUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Salary/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateSalary = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Salary/Edit/"+id,p,
       function(resp){
           $location.path("/admin_salaryRead");
       },
       function(err){});

     };
});
