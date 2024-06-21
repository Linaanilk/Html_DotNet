function recursive_factorial(num) {
    if (num == 1) {
        return 1;
    } else {
        return num * recursive_factorial(num - 1);
    }
}

function factorial() {
    var num = document.getElementById('number').value;
    num = parseInt(num);
    var result = recursive_factorial(num);
    alert('The factorial of ' + num + ' is: ' + result);
}

