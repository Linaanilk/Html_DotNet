function appendopp(num)
{
    var val=document.getElementById('name').value+=num
 
}
function clear1()
{
    document.getElementById('name').value='';
}
function calculate()
{
    try{
    document.getElementById('name').value=eval(document.getElementById('name').value)
    }
    catch(error)
    {
        alert('error')
    }
}