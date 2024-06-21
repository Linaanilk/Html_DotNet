abstract class person
{
    name:string;

    constructor(name:string)
    {
        this.name=name;
    }
    display(): void{
        console.log(this.name)
    }
    abstract find(string):person;
}

class Employee extends person
{

    empCode:number;

    constructor(name:string,code:number)
    {
        super(name);
        this.empCode=code;
    }
    find(name:string): person {
        return new Employee(this.name,1);
    }
    // find(string: any): Person {
    //     throw new Error("Method not implemented.");

}
let emp:person=new Employee("James",100);
emp.display();