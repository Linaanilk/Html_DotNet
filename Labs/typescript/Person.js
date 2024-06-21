var person = /** @class */ (function () {
    function person(name) {
        this.name = name;
    }
    person.prototype.display = function () {
        console.log(this.name);
    };
    return person;
}());
