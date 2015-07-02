//Task 01:
function greatestNumber() {
	var a = parseFloat(document.getElementById('greatest1').value);
	var b = parseFloat(document.getElementById('greatest2').value);
	var result = "";

	if (a > b) {
		var change = a;
		a = b;
		b = change;
	}

	result = 'Result Task 1: <span style="color:red;">"' + a + ' ' + b + '"</span>';
	document.getElementById('result1').innerHTML = result;
}

//Task 02:
function showSign() {
	var a = parseFloat(document.getElementById('number1').value);
	var b = parseFloat(document.getElementById('number2').value);
	var c = parseFloat(document.getElementById('number3').value);
	var minus = 0;
	var result = "";
	var arr = [a.toString(), b.toString(), c.toString()];

	for (var i = 0; i < arr.length; i++) {
		if (arr[i][0] === "-") {
			minus++;
		}
	}

	if (minus % 2 === 0) {
		result = "+";
	} else {
		result = "-";
	}

	if (a === 0.0 || b === 0.0 || c === 0.0) {
		result = "0";
	}
	
	var printStr = 'Result Task 2: ';
    document.getElementById('result2').innerHTML = printStr + ' -> <span style="color:red;">"' + result + '"</span>';
}

//Task 03:
function findBiggest() {
	var a = parseFloat(document.getElementById('integer1').value);
	var b = parseFloat(document.getElementById('integer2').value);
	var c = parseFloat(document.getElementById('integer3').value);
	var result = 0;

	if (a > b) {
		if (a > c) {
			result = a;
		} else {
			result = c;
		}
	} else {
		if (b > c) {
			result = b;
		} else {
			result = c;
		}
	}

	document.getElementById('result3').innerHTML = 'Result Task 3: The biggest = <span style="color:red;">"' + result + '"</span>';
}

//Task 04:
function sortNumbers() {
	var a = parseFloat(document.getElementById('sort1').value);
	var b = parseFloat(document.getElementById('sort2').value);
	var c = parseFloat(document.getElementById('sort3').value);
	var result = "";
	var highest;
	var second;
	var third;

	if (a > b) {
		if (a > c) {
			highest = a;

			if (b > c) {
				second = b;
				third = c;
			} else {
				second = c;
				third = b;
			}
		} else {
			highest = c;
			second = a;
			third = b;
		}
	} else {
		if (b > c) {
			highest = b;

			if (a > c) {
				second = a;
				third = c;
			} else {
				second = c;
				third = a;
			}
		} else {
			highest = c;
			second = b;
			third = a;
		}
	}

	result = '<span style="color:red;">"' + highest + ", " + second + ", " + third + '"</span>';
	document.getElementById('result4').innerHTML = 'Result Task 4: Sorted numbers -> ' + result;
}

//Task 05:
function writeInEnglish() {
	var n = parseInt(document.getElementById('digit').value);
	var digit;

	switch (n) {
		case 0: digit = 'zero'; break;
		case 1: digit = 'one'; break;
		case 2: digit = 'two'; break;
		case 3: digit = 'three'; break;
		case 4: digit = 'four'; break;
		case 5: digit = 'five'; break;
		case 6: digit = 'six'; break;
		case 7: digit = 'seven'; break;
		case 8: digit = 'eight'; break;
		case 9: digit = 'nine'; break;
		default: digit = 'not a digit'; break;
	}

	document.getElementById('result5').innerHTML = 'Result Task 5: <span style="color:red;">"' + digit + '"</span>';
}

//Task 06:
function calculateRoots() {
	var a = parseFloat(document.getElementById('numA').value);
	var b = parseFloat(document.getElementById('numB').value);
	var c = parseFloat(document.getElementById('numC').value);
	var endResult = "";
	var result1;
	var result2;
	var isThereRoots;

	if (a != 0) {
		isThereRoots = b * b - 4 * a * c;
		
		if (isThereRoots > 0) {
			result1 = (-b - Math.sqrt(isThereRoots)) / (2 * a);
			result2 = (-b + Math.sqrt(isThereRoots)) / (2 * a);			            
		    
		    endResult = "x1 = " + result1 + "; x2 = " + result2;
	    } else if (isThereRoots == 0) {
			result1 = (-b) / (2 * a);
			
			endResult = "x1 = x2 = " + result1;
		} else if (isThereRoots < 0) {
			endResult = "no real roots";
		}
	} else if (b != 0) {
		result1 = (-c) / b;
		
		endResult = "x1 = x2 = " + result1;
	} else {
		endResult = "no real roots";
	}

	document.getElementById('result6').innerHTML = 'Result Task 6: <span style="color:red;">"' + endResult + '"</span>';
}

//Task 07:
function findGreatest() {
	var arr = new Array(5);
	arr[0] = parseFloat(document.getElementById('variable1').value);
	arr[1] = parseFloat(document.getElementById('variable2').value);
	arr[2] = parseFloat(document.getElementById('variable3').value);
	arr[3] = parseFloat(document.getElementById('variable4').value);
	arr[4] = parseFloat(document.getElementById('variable5').value);
	var max = arr[0];

	for (var i = 1; i < arr.length; i++) {
		if (arr[i] > max) {
			max = arr[i];
		}
	}

	document.getElementById('result7').innerHTML = 'Result Task 7: <span style="color:red;">"' + max + '"</span>';	
}

//Task 08:
function convertInEnglish() {
	var number = document.getElementById('digitConverting').value;
	var num = parseInt(number)
	var numberText;
    var array = new Array(number.length)

	if (number > 999) {
		document.getElementById('result8').innerHTML = 'Result Task 8: The number: ' + number + ' -> <span style="color:red;">Incorrect input</span>';
	}
	
	else {
		if (number < 0) {
			document.getElementById('result8').innerHTML = 'Result Task 8: The number: ' + number + ' -> <span style="color:red;">Incorrect input</span>';
		}
		else{
			for (var index = 0; index < number.length; index++) {
			    array[index] = num % 10;
			    num = parseInt((num / 10));
			    
			    if (index == 0) {
			        switch (array[index]) {
			            case 0: numberText = "zero"; break;
			            case 1: numberText = "one"; break;
			            case 2: numberText = "two"; break;
			            case 3: numberText = "three"; break;
			            case 4: numberText = "four"; break;
			            case 5: numberText = "five"; break;
			            case 6: numberText = "six"; break;
			            case 7: numberText = "seven"; break;
			            case 8: numberText = "eight"; break;
			            case 9: numberText = "nine"; break;
			        }
			    }
	        
			        if (index == 1) {
			            
			            if (array[index] == 1) {
			                switch (array[0]) {
			                    case 0: numberText = "ten"; break;
			                    case 1: numberText = "eleven"; break;
			                    case 2: numberText = "twelve"; break;
			                    case 3: numberText = "thirteen"; break;
			                    case 4: numberText = "fourteen"; break;
			                    case 5: numberText = "fifteen"; break;
			                    case 6: numberText = "sixteen"; break;
			                    case 7: numberText = "seventeen"; break;
			                    case 8: numberText = "eighteen"; break;
			                    case 9: numberText = "nineteen"; break;
			                }
			            }
			            else {
			                switch (array[index]) {
			                    case 2: numberText = "twenty" + " " + numberText; break;
			                    case 3: numberText = "thirty" + " " + numberText; break;
			                    case 4: numberText = "forty" + " " + numberText; break;
			                    case 5: numberText = "fifty" + " " + numberText; break;
			                    case 6: numberText = "sixty" + " " + numberText; break;
			                    case 7: numberText = "seventy" + " " + numberText; break;
			                    case 8: numberText = "eighty" + " " + numberText; break;
			                    case 9: numberText = "ninety" + " " + numberText; break;
			                    case 0:
			                    
			                    if (number.length == 3) {
			                        numberText = "and" + " " + numberText;
			                    }			                   
			                	break;
		 					}
			            }
			        }
			        
			        if (index == 2) {
			            
			            if ((array[0] == 0) && (array[1] == 0)) {
			                numberText = "";
			            }
			            
			            else if (array[1] == 1) {
			                numberText = "and" + " " + numberText;
			            }
			            
			            switch (array[index]) {
							case 1: numberText = "one hundred" + " " + numberText; break;
			                case 2: numberText = "two hundred" + " " + numberText; break;
			                case 3: numberText = "three hundred" + " " + numberText; break;
			                case 4: numberText = "four hundred" + " " + numberText; break;
			                case 5: numberText = "five hundred" + " " + numberText; break;
			                case 6: numberText = "six hundred" + " " + numberText; break;
			                case 7: numberText = "seven hundred" + " " + numberText; break;
			                case 8: numberText = "eight hundred" + " " + numberText; break;
			                case 9: numberText = "nine hundred" + " " + numberText; break;
			                case 0: numberText = "Incorrect input!"; break;
			                }
	        		}
	    		}
	    numberText = numberText.charAt(0).toUpperCase() + numberText.slice(1);	    
	    document.getElementById('result8').innerHTML = 'Result Task 8: The number: ' + number + ' -> <span style="color:red;">' + numberText + '</span>';
		}
	}
}