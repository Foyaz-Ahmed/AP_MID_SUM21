app.controller("Products",function($scope,$http,ajax){
    ajax.get("https://localhost:44326//api/Product/All",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
