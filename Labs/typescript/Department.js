var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var department = /** @class */ (function () {
    function department(departmentname, vertical, numberofemployees, floornumber) {
        this.numberofemployees = numberofemployees;
        this.floornumber = floornumber;
        this.departmentname = departmentname;
        this.vertical = vertical;
        console.log("The ".concat(departmentname, " belongs to the ").concat(vertical, " has ").concat(numberofemployees, " and is located on the floor ").concat(floornumber));
    }
    return department;
}());
var Tech = /** @class */ (function (_super) {
    __extends(Tech, _super);
    function Tech(name, vertical, numberEmployees, floorNumber) {
        return _super.call(this, name, vertical, numberEmployees, floorNumber) || this;
    }
    Tech.prototype.NumberOftables = function () {
        return this.numberofemployees / 5;
    };
    return Tech;
}(department));
var backend = new Tech('Technology Services', 'Tech', 50, 10);
console.log(backend.NumberOftables());
