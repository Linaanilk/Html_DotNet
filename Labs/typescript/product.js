"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var List = /** @class */ (function () {
    function List() {
        this.list = [];
    }
    List.prototype.add = function (entity) {
        this.list.push(entity);
    };
    List.prototype.delete = function () {
        this.list.pop();
    };
    List.prototype.showList = function () {
        this.list.forEach(function (entity) {
            console.log(entity);
        });
    };
    return List;
}());
var product1 = {
    id: 1,
    name: "laptop",
    image: new URL('https://google.com'),
    date: new Date(2023, 10, 10),
    price: 50000
};
var product2 = {
    id: 2,
    name: "Watch",
    image: new URL('https://google.com'),
    date: new Date(2023, 10, 10),
    price: 1000
};
var productlist = new List();
productlist.add(product1);
productlist.add(product2);
productlist.showList();
var emp_1 = require("./emp");
var emp1 = {
    employeeid: 1,
    employeename: "param",
    Email: "param@speridian.com",
    dojoining: new Date("2023,10,10"),
    Gender: emp_1.Gender.Male
};
var emp2 = {
    employeeid: 2,
    employeename: "karan",
    Email: "karamehr@speridian.com",
    dojoining: new Date("2023,10,12"),
    Gender: emp_1.Gender.Female
};
var list = new List();
list.add(emp1);
list.add(emp2);
list.showList();
