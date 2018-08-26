

describe('home page', function () {

    beforeEach(function() {
        browser.get('http://localhost:50059/Student#!/');
    })

    it('shoud add new student', function() {

        element(by.css('#btnAddNew')).click();

        expect(browser.getCurrentUrl()).toContain('AddNew');

    })

    it('should contain list of students with first element as Waqar Younas', function () {

        expect(element(by.css('.ng-binding')).getText()).toEqual('Waqar')


    })

})