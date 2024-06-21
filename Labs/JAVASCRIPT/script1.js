function ShowMessage()
{
    // var password ='abcd';
    // password=1234;
    // console.log(password)
var name=document.getElementById('name').value
alert('welcome  ' +name);
alert(name.length);
console.log(name.toUpperCase())
console.log(name.toLowerCase())
var num1=5
var num2="4"
var total=num1+parseInt(num2)
console.log(total)
var y=null;
console.log(y);
var students=["john","joana","jane","jasmin"]
}

function arrayOps()
{
    var numbers=[1,2,3,4]
    numbers.push(7);
    numbers.pop()
    numbers.pop()
    // delete numbers[0]
    var text=0;
    for (var i = 0; i < numbers.length; i++) 
    {
        text += numbers[i] 
      }
      
     alert(text);
}

function update()
{
var name=document.getElementById('name').value
document.getElementById('head').innerHTML='Welcome ' +name;
}

function color()
{
    var col=document.getElementById('col').value
    document.getElementById("head").style.color=col
}

document.getElementById('btn').addEventListener('click',color());