app.controller("ShowOrders",function($scope,$http,ajax){
    ajax.get("https://localhost:44326//api/OrderDetails/All",success,error);
    function success(response){
      $scope.details=response.data;
    }
    function error(error){

    }

});
