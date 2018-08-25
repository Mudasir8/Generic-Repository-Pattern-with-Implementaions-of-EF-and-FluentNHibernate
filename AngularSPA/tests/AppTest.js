
describe('App Tests', function () {

    
    beforeEach(angular.mock.module('myApp')); // ***************** have to resister before each test

    describe('reversestringfilterTest', function () {

        var reverse;
        beforeEach(angular.mock.inject(function ($filter) { //initialize filter
            reverse = $filter('reverse', {});
        }));

        it('Should return a string length', function () {
            expect(reverse('india')).toBe(5); //pass test
            expect(reverse('don')).toBe(3); //fail test
        });

    });

    describe('cotroller test', function () {
        var $controller;
       // var $http;

        beforeEach(angular.mock.inject(function (_$controller_) {
            $controller = _$controller_;
           // $http = _$http_;
        }));

        it('should return student list with lenth 3', function () {
            var $scope = {};
            var $http = {};
            var controller = $controller('myController', { $scope: $scope, $http: $http });
            $scope.startList();
            alert($scope.studentList);
            expect($scope.studentList.length).toBeDefined();

        })

    });

});


