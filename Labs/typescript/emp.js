"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Gender = void 0;
var Gender;
(function (Gender) {
    Gender[Gender["Male"] = 0] = "Male";
    Gender[Gender["Female"] = 1] = "Female";
})(Gender || (exports.Gender = Gender = {}));
var employeeList = /** @class */ (function () {
    function employeeList() {
        this.List = [];
    }
    employeeList.prototype.add = function (emp) {
        this.List.push(emp);
    };
    employeeList.prototype.delete = function () {
        this.List.pop();
    };
    employeeList.prototype.ShowList = function () {
        this.List.forEach(function (emp) {
            console.log(emp);
        });
    };
    return employeeList;
}());
var emp1 = {
    employeeid: 1,
    employeename: "param",
    Email: "param@speridian.com",
    dojoining: new Date("2023,10,10"),
    Gender: Gender.Male
};
var emp2 = {
    employeeid: 2,
    employeename: "karan",
    Email: "karamehr@speridian.com",
    dojoining: new Date("2023,10,12"),
    Gender: Gender.Female
};
var list = new employeeList();
list.add(emp1);
list.add(emp2);
list.ShowList();
