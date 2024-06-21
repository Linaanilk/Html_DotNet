function addemp()
{
    var gender;
    if(document.getElementById('male').checked)
        gender='male';
    else
        gender='female';
    var emp={
    Name :document.getElementById('name').value,
Email : document.getElementById('email').value,
pincode : document.getElementById('pincode').value,
DOB : document.getElementById('dob').value,
skills : document.getElementById('skills').value,
gender:gender,
country : document.getElementById('country_name').value,
rating: document.getElementById('rating').value


};
console.log(emp);

var a=10;
var b=a;
// a=15;
console.log(a,b)
}

