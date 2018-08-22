
var myApp = angular.module('myApp', [])

myApp.controller('myController', function MyController($scope, $http) {

    // get list from Student/GetStudentsList
    $http.get("/Student/GetStudentsList")
        .then(function (response) {
            $scope.studentList = response.data;
        });

}); // /controller