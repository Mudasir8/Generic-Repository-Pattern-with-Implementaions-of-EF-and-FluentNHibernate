
describe('App Tests', function () {

    beforeEach(angular.mock.module('myApp'));

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


});