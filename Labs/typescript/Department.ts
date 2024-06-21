abstract class department
{
    numberofemployees:number;
    floornumber:number;
    departmentname:string;
    vertical:string
    constructor(departmentname:string,vertical:string,numberofemployees:number,floornumber:number)
    {
        this.numberofemployees=numberofemployees;
        this.floornumber=floornumber;
        this.departmentname=departmentname;
        this.vertical=vertical;
        console.log(`The ${departmentname} belongs to the ${vertical} has ${numberofemployees} employees and is located on the floor ${floornumber}`)
    }
    abstract NumberOftables();
    
}

class Tech extends department
{

   

    constructor(name:string, vertical:string,numberEmployees:number,floorNumber:number)
    {
super(name,vertical,numberEmployees,floorNumber)
    }
    NumberOftables()
    {
        return this.numberofemployees/5
    }

}
let backend=new Tech('Technology Services','Tech',50,10);
console.log(backend.NumberOftables());