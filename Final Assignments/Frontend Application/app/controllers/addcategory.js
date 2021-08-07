app.controller("addcategory",function($scope,ajax,$location){

    $scope.addcategory = function(){
        //$scope.Name
        var d = {
          id:0,
          name:$scope.name
        };
        ajax.post("https://localhost:44326/api/Category/Add",d,
        function(response){
            $location.path("/Categories");
        },
        function(err){

        });
    };
});
