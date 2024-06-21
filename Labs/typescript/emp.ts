


export enum Gender
{
    Male,
    Female
}
export interface Employee {
    employeeid: number;
    employeename: string;
    Email: string;
    dojoining: Date;
    Gender: Gender;

}

class employeeList{
    private List:Employee[]=[];
    add(emp:Employee)
    {
        this.List.push(emp);
    }
    delete()
    {
        this.List.pop();
    }
    ShowList()
    {
        this.List.forEach(emp => {
            console.log(emp)
        });
    }
}
let emp1:Employee=
{
employeeid:1,
employeename:"param",
Email:"param@speridian.com",
dojoining:new Date("2023,10,10"),

Gender:Gender.Male
}

let emp2:Employee=
{
   employeeid:2,
    employeename:"karan",
    Email:"karamehr@speridian.com",
dojoining:new Date("2023,10,12"),

Gender:Gender.Female
}
let list=new employeeList();
list.add(emp1);
list.add(emp2);
list.ShowList();