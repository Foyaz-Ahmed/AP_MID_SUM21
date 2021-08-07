app.controller("OrderDetails",function($scope,$http,ajax){
    ajax.get("https://localhost:44326//api/Product/All",success,error);
     $scope.date = new Date();
     $scope.status = "cancelled";
     function success(response){

       $scope.products=response.data;

    }
    function error(error){

    }



});
