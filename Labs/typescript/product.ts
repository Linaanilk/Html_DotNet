interface product
{
    id:number;
    name:string;
    image:URL;
    date:Date;
    price:number
}
class List<T>{
    private list:T[]=[]
    add(entity:T)
    {
        this.list.push(entity);
    }
    delete()
    {
        this.list.pop();
    }
    showList()
    {
        this.list.forEach(entity =>{
            console.log(entity)
        });
    }
}
let product1:product=
{
    id:1,
    name:"laptop",
    image:new URL('https://google.com'),
    date:new Date(2023,10,10),
    price:50000
}
let product2:product=
{
    id:2,
    name:"Watch",
    image:new URL('https://google.com'),
    date:new Date(2023,10,10),
    price:1000
}
let productlist=new List<product>();
productlist.add(product1);  
productlist.add(product2);
productlist.showList();


import { Employee } from "./emp";
import { Gender } from "./emp";

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
let list=new List<Employee>();

list.add(emp1);
list.add(emp2);
list.showList();