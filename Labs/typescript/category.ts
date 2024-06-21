class category
{
    private id:number;
    private name:string;

    constructor(id:number)
    {
        this.id=id;
        // this.name=name;

    }
    static description:string='A source of knowledge';
    add(name:string):boolean
    {
        this.name=name;
        return true
    }
    show()
    {
        console.log(`category id:${this.id},Name:${this.name}`);
    }
}
let electronics =new category(1);
electronics.add('Electronics');
electronics.show();

let desc=category.description;
console.log(desc);