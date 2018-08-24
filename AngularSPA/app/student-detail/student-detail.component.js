
angular.
    module('studentDetail').
    component('studentDetail', {
        templateUrl: '/app/student-detail/student-detail.template.html',
        controller: ['$http', '$routeParams',
            function StudentDetailController($http, $routeParams) {
                var self = this;

                $http.get('/Student/GetStudentByID/' + $routeParams.studentID).then(function (response) {
                    self.student = response.data;
                });

            }
        ]
    });