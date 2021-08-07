app.controller("addproduct",function($scope,ajax,$location){

    ajax.get("https://localhost:44326/api/Category/GetAll",
    function(resp){
      $scope.ctg = resp.data;
    },
    function(err){

    });

    $scope.addproduct = function(p){
        //$scope.Name
        ajax.post("https://localhost:44326/api/Proudcts/add",p,
        function(resp){
            $location.path("/Products");
        },
        function(err){});

      };
});
