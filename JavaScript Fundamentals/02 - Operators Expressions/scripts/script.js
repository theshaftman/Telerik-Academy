//Task 01:
function onButtonClick() {
	var number = parseInt(document.getElementById('getNumber').value);
    var result1 = "";
    var odd = true;

    if (number % 2 === 0) {
        odd = false;
    }

	document.getElementById('result1').innerHTML = 'Result Task 1: Odd => <span style="color:red;">"' + odd + '"</span>';
}

//Task 02:
function ifDividedBy7and5() {
	var number = parseInt(document.getElementById('divideCheck').value);
    var divisible = false;

    if (number % 5 == 0 && number % 7 == 0) {
        divisible = true;
    }

    document.getElementById('result2').innerHTML = 'Result Task 2: <span style="color: red;">"' + divisible + '"</span>';
}

//Task 03:
function rectangleArea() {
	var width = parseFloat(document.getElementById('width').value);
	var height = parseFloat(document.getElementById('height').value);
	var result = (width * height);

	document.getElementById('result3').innerHTML = 'Result Task 3: The Rectangle`s area = <span style="color:red;">"' + result + '"</span>';
}

//Task 04:
function onCheckDigit() {
	var number = document.getElementById('checkDigit').value;
    var isDigit7 = false;

    if (number[number.length - 3] === "7") {
        isDigit7 = true;
    }

    document.getElementById('result4').innerHTML = 'Result Task 4: <span style="color:red;">"' + isDigit7 + '"</span>';
}

//Task 05:
function onCheckBit() {
	var n = parseInt(document.getElementById('thirdBit').value);
    var number = n.toString(2);
	var thirdBit = number[number.length - 4];

    if (typeof(thirdBit) === "undefined") {
        thirdBit = 0;
    }

    document.getElementById('result5').innerHTML = 'Result Task 5: Bit #3 = <span style="color:red;">"' + thirdBit + '"</span>';    
}

//Task 06:
function inCircle() {
	var x = parseFloat(document.getElementById('xOfPrint').value);
	var y = parseFloat(document.getElementById('yOfPrint').value);
	var inCirc = false;
    var radius = 5;

    if ((x * x) + (y * y) <= (radius * radius)) {
        inCirc = true;
    }

    document.getElementById('result6').innerHTML = 'Result Task 6: In circle => <span style="color:red;">"' + inCirc + '"</span>';
}

//Task 07:
function checkIfPrime() {
	var number = parseInt(document.getElementById('ifPrime').value);
    var result = true;

    if (number < 2) {
        result = false;
    } else if (number > 100) {
        document.getElementById('result7').innerHTML = 'Result Task 7: <span style="color:red;">"Write a number less than 100!"</span>';
        return;
    }

    for (var i = 2; i < number; i++) {
        if (number % i === 0) {
            result = false;

            break;
        }
    }

    document.getElementById('result7').innerHTML = 'Result Task 7: <span style="color:red;">"' + result + '"</span>';
}

//Task 08:
function trapezoidArea() {
	var a = parseFloat(document.getElementById('sideA').value);
	var b = parseFloat(document.getElementById('sideB').value);
	var h = parseFloat(document.getElementById('heightH').value);
	
    var area = ((a + b) / 2) * h;
    document.getElementById('result8').innerHTML = 'Result Task 8: The Trapezoid`s area = <span style="color:red;">"' + area + '"</span>';
}

//Task 09:
function inCircleOutRectangle() {
	var x = document.getElementById('xOfPoint').value;
	var y = document.getElementById('yOfPoint').value;
	var result;
	
	var isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < 3 * 3;
    var isOutOfRectangle = !((x >= -1 && x <= 5) && (y <= 1 && y >= -1));
    
    result = isInCircle && isOutOfRectangle ? "yes" : "no";

    document.getElementById('result9').innerHTML = 'Result Task 9: Inside K & outside of R => <span style="color:red;">"' + result + '"</span>';
}