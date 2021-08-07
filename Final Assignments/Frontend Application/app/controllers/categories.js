app.controller("categories",function($scope,$http,ajax){
    ajax.get("https://localhost:44326/api/Category/GetAll",success,error);
    function success(response){
      $scope.ctg=response.data;
    }
    function error(error){

    }

});
