﻿
var myApp = angular.module('myApp', [
    'ngRoute',
    'studentDetail',
])

myApp.controller('myController', function MyController($scope, $http) {

    // get list from Student/GetStudentsList
    $http.get("/Student/GetStudentsList")
        .then(function (response) {
            $scope.studentList = response.data;
        });

    $scope.deleteStudent = function (id) {
        if (confirm("Are you sure do delete ?")) {
            // remove from server
            $http({
                url: "/Student/DeleteStudentByID",
                method: "GET",
                params: { id: id }
            }).then(function (response) {
                    if (response.data) {
                        // remove from client list
                        $scope.studentList = $scope.studentList.filter(x => x.ID != id);
                    }
                });


        }

    };


}); // /controller

// Temp for testing
myApp.filter('reverse', function () {
    return function (text) {
        return text.length;
    };
});