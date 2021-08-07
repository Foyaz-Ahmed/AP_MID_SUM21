app.controller("details",function($scope,$http,ajax, $routeParams){
    $scope.id = $routeParams.id;
    ajax.get("https://localhost:44326/api/Product/3",success,error);
     function success(response){

       $scope.products=response.data;

    }
    function error(error){

    }

});
