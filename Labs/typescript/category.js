var category = /** @class */ (function () {
    function category(id) {
        this.id = id;
        // this.name=name;
    }
    category.prototype.add = function (name) {
        this.name = name;
        return true;
    };
    category.prototype.show = function () {
        console.log("category id:".concat(this.id, ",Name:").concat(this.name));
    };
    category.description = 'A source of knowledge';
    return category;
}());
var electronics = new category(1);
electronics.add('Electronics');
electronics.show();
var desc = category.description;
console.log(desc);
