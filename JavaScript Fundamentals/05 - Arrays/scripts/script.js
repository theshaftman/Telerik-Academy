//Task 1:
function increaseArrayMembers () {
	var arr = new Array(20);

	for (var i = 0; i < arr.length; i++) {
		arr[i] = i * 5;
	}

	document.getElementById('result1').innerHTML = 'Result Task 1: <span style="color: red;">' + arr.join(', ') + '</span>';
}

//Task 2:
function lexicographicallyComparison() {
	var arrayOneAsString = document.getElementById('arrayA').value;
	var arrayTwoAsString = document.getElementById('arrayB').value;
	var arrayA = arrayOneAsString.split(' ');
	var arrayB = arrayTwoAsString.split(' ');
	
	var equal = false;

	if (arrayA.length === arrayB.length) {
		for (var i = 0; i < arrayA.length; i++) {
			if (parseFloat(arrayA[i]) === parseFloat(arrayB[i])) {
				equal = true;
			} else {
				equal = false;

				break;
			}
		}
	}

	document.getElementById('result2').innerHTML = 'Result Task 2: <span style="color: red;">' + equal + '</span>';
}

//Task 3:
function maximalSequence() {
	var arrayString = document.getElementById('writeCommonArray').value;
	var arr = arrayString.split(' ');

	var equal = 1;
	var equalArr = new Array(arr.length);
	var valueArr = new Array(arr.length);
	var index = 0;

	for (var i = 1; i <= arr.length; i++) {
		if (parseFloat(arr[i - 1]) === parseFloat(arr[i])) {
			equal++;
		} else {
			equalArr[index] = parseFloat(equal);
			valueArr[index] = parseFloat(arr[i - 1]);
			equal = 1;
			index++;
		}
	}

	var maxIndex = 0;
	var max = equalArr.reduce(function (previous, current) { 
          	return previous > current ? previous : current;
       	});

	for (var j = 0; j < equalArr.length; j++) {
	 	if (equalArr[j] === max) {
	 		maxIndex = j;
	 	}
	}

	var result = "";

	for (var k = 0; k < equalArr[maxIndex]; k++) {
	  	result += valueArr[maxIndex].toString();

	  	if (k < equalArr[maxIndex] - 1) {
	  		result += ", ";
	  	}
	}

	document.getElementById('result3').innerHTML = 'Result Task 3: <span style="color: red;">' + result + '</span>';
}

//Task 4:
function maximalIncreasingSequence() {
	var arrayString = document.getElementById('writeIncreasingArray').value;
	var arr = arrayString.split(' ');
	
	var equal = 1;
	var equalArr = new Array(arr.length);
	var valueArr = new Array(arr.length);
	var indexArr = new Array(arr.length);
	var index = 0;

	for (var i = 1; i <= arr.length; i++) {
		if (parseFloat(arr[i]) > parseFloat(arr[i - 1])) {
			equal++;
		} else {
			equalArr[index] = parseFloat(equal);
			valueArr[index] = parseFloat(arr[i - 1]);
			indexArr[index] = parseFloat(i - 1);
			equal = 1;
			index++;
		}
	}

	var maxIndex = 0;
	var max = equalArr.reduce(function (previous, current) { 
          	return previous > current ? previous : current;
       	});

	for (var j = 0; j < equalArr.length; j++) {
	 	if (equalArr[j] === max) {
	 		maxIndex = j;
	 	}
	}

	var result = "";
	var indexResult = equalArr[maxIndex];

	for (var k = 0; k < equalArr[maxIndex]; k++, indexResult--) {
	  	result += arr[indexArr[maxIndex] - (indexResult - 1)].toString();

	  	if (k < equalArr[maxIndex] - 1) {
	  		result += ", ";
	  	}
	}

	document.getElementById('result4').innerHTML = 'Result Task 4: <span style="color: red;">' + result + '</span>';
}

//Task 5:
function selectionSort() {
	var arrayString = document.getElementById('sortArray').value;
	var arr = arrayString.split(' ');
	
	var result = new Array(arr.length);

	//Sort by value
	for (var i = 0; i < arr.length; i++) {
		if (i === 0) {
			var min = parseFloat(arr[0]);

			for (var j = 0; j < arr.length; j++) {
				if (parseFloat(arr[j]) < min) {
					min = arr[j];
				}
			}

			result[0] = min;
		} else {
			var val;

			for (var k = 0; k < arr.length; k++) {
				if (parseFloat(arr[k]) > parseFloat(result[i - 1])) {
					val = arr[k];

					break;
				}
			}

			for (var l = 0; l < arr.length; l++) {
				if (parseFloat(arr[l]) > parseFloat(result[ i - 1]) && parseFloat(arr[l]) < val) {
					val = arr[l];
				}
			}

			result[i] = val;
		}
	}

	//Get the repeated values
	var repeated = new Array(arr.length);
	var repeatedTimes = 0;

	for (var m = 0; m < arr.length; m++) {
		for (var n = 0; n < arr.length; n++) {
			if (arr[m] === arr[n]) {
				repeatedTimes++;
			}
		}

		repeated[m] = repeatedTimes;
		repeatedTimes = 0;
	}
	
	//Creating the final result
	var endResult = "";
	var length = arr.length;

	for (var o = 0; o < length; o++) {
		for (var p = 0; p < arr.length; p++) {
			if (result[o] === arr[p]) {
				endResult += result[o].toString() + " ";
			}
		}
	}

	//Split the final result into array
	var endResultArr = endResult.split(' ', arr.length);

	document.getElementById('result5').innerHTML = 'Result Task 5: <span style="color: red;">' + endResultArr.join(', ') + '</span>';
}

//Task 6:
function mostFrequentNumber() {
	var arrayString = document.getElementById('findArray').value;
	var arr = arrayString.split(' ');
	var result = "";
	var maxRepeated = 0;
	var maxRepeatedValue;

	for (var i = 0, repeated = 0; i < arr.length; i++) {
		for (var j = 0; j < arr.length; j++) {
			if (arr[i] === arr[j]) {
				repeated++;
			}
		}

		if (repeated > maxRepeated) {
			maxRepeated = repeated;
			maxRepeatedValue = arr[i];
		}

		repeated = 0;
	}

	result = maxRepeatedValue.toString() + " (" + maxRepeated.toString() + " times)";
	
	document.getElementById('result6').innerHTML = 'Result Task 6: <span style="color: red;">' + result + '</span>';
}

//Task 7:
function binSearch() {
	var arrayString = document.getElementById('arrayElements').value;
	var value = parseFloat(document.getElementById('selectedElement').value);
	var array = arrayString.split(' ');

	document.getElementById('result7').innerHTML = 'Result Task 7: <span style="color: red;">' + 
		binarySearch(array, value, 0, array.length) + '</span>';
}

function binarySearch(arr, value, lowIndex, highIndex) {
	arr = arr.sort(function(a, b) { return a - b });

    if (highIndex < lowIndex) {
        return null;
    }

    var middle = Math.floor((lowIndex + highIndex)/2);

    if (arr[middle] > value) {
        return binarySearch(arr, value, lowIndex, middle - 1);
    } else if (arr[middle] < value) {
        return binarySearch(arr, value, middle + 1, highIndex);
    } else {
        return middle;
    }
}