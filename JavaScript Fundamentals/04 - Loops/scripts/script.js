//Task 01:
function printNumbers() {
	var number = document.getElementById('numbers').value;
	var numbersStr = "";

	for (var i = 1; i <= number; i++) {
		numbersStr += i + " ";
	}

	console.log('Result Task 1: ' + numbersStr);
	document.getElementById('result1').innerHTML = 'Result Task 1: The numbers from 1 to ' + number + 
		' -> <span style="color:red;">' + numbersStr + '</span>';
}

//Task 02:
function printNumbersNotDivisible() {
	var numberNotDiv = document.getElementById('numbersNotDiv').value;
	var numbersStr = "";

	for (var i = 1; i <= numberNotDiv; i++) {
		if (i % 3 != 0 || i % 7 != 0) {
			numbersStr += i + " ";
		}
	}

	console.log('Result Task 2: ' + numbersStr);
	document.getElementById('result2').innerHTML = 'Result Task 2: The numbers from 1 to ' + 
		numberNotDiv + ', NOT divisible by 3 and 7 -> <span style="color:red;">' + numbersStr + '</span>';	
}

//Task 03:
function findMaxAndMin() {
	var numbers = document.getElementById('number').value;
	var arr = numbers.split(" ");

	var min = parseInt(arr[0]);
	var max = parseInt(arr[0]);

	for (var i = 0; i < arr.length; i++) {
		if (parseInt(arr[i]) > max) {
			max = parseInt(arr[i]);
		} else if (parseInt(arr[i]) < min) {
			min = parseInt(arr[i]);
		}
	}
	
	var outTxt = 'Min number = <span style="color:red;">' + min + '</span>; Max number = <span style="color:red;">' + max + '</span>;';

	console.log('Result Task 3: The Min number -> ' + min + ' and the Max number -> ' + max);
	document.getElementById('result3').innerHTML = 'Result Task 3: ' + outTxt;
}

//Task 04:
function findProperties() {
    findSmallest(document);
    findBiggest(document);
	findSmallest(window);
    findBiggest(window);
    findSmallest(navigator);
    findBiggest(navigator);

    function findSmallest(object) {
        var smallest = 'zzz';
   	    for (var property in object) {
            if (property < smallest) {
                smallest = property;
            }
        }

        console.log('The smallest lexicographically property in ' + object + ' is ' + smallest);        
    	document.getElementById("result4").innerHTML += "The smallest lexicographically property in " + object + " is " + smallest + "\n";
    }
    
    function findBiggest(object) {
        var biggest = 'AAA';
        for (var property in object) {
    
            if (property > biggest) {
                biggest = property;
            }
        }

        console.log('The biggest lexicographically property in ' + object + ' is ' + biggest);
        document.getElementById("result4").innerHTML += "The biggest lexicographically property in " + object + " is " + biggest + "\n";
    }
}