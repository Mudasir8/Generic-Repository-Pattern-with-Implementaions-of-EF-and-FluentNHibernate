
angular.
    module('myApp').
    config(['$locationProvider', '$routeProvider',
        function config($locationProvider, $routeProvider) {
            $locationProvider.hashPrefix('!');

            $routeProvider.
                when('/', {
                    templateUrl: '/app/templates/StudentList.html'
                }).
                when('/AddNew', {
                    templateUrl: '/app/student-add-new/student-add-new.template.html'
                }).
                when('/:studentID', {
                    template: '<student-detail></student-detail>'
                }).
                otherwise('/');
        }
    ]);

