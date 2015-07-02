//Task 01:
function englishDigit(number) {
	var n = document.getElementById('givenNumber').value;
    var str = n.toString();
    var result = "";

    switch(str[str.length - 1]) {
        case "0": result = "zero"; break;
        case "1": result = "one"; break;
        case "2": result = "two"; break;
        case "3": result = "three"; break;
        case "4": result = "four"; break;
        case "5": result = "five"; break;
        case "6": result = "six"; break;
        case "7": result = "seven"; break;
        case "8": result = "eight"; break;
        case "9": result = "nine"; break;
    }

    document.getElementById('result1').innerHTML = 'Result Task 1: <span style="color:red;">' + result + '</span>';
}

//Task 02:
function reverseNumber(number) {
	var number = document.getElementById('numberReverse').value;
    var str = number.toString();
    var result = str.split("").reverse().join("");

    document.getElementById('result2').innerHTML = 'Result Task 2: <span style="color:red;">' + result + '</span>';
}

//Task 03:
function occurencesOfWord(){
    var text = document.getElementById('textArea').value;
    var word = document.getElementById('wordSearch').value;
    var caseS = document.getElementsByName('caseSens');
    var caseSensitive = caseS[0].checked; //Case sensitive
    var arr;

    if (caseSensitive === true) {
        arr = text.replace('.', '').replace(',', '').replace('!', '').replace('?', '').replace('-', '').replace(':', '').
            replace(';', '').replace('(', '').replace(')', '').replace('\"', '').replace('\'', '').split(' ');
    } else {
        word = word.toLowerCase();
        arr = text.replace('.', '').replace(',', '').replace('!', '').replace('?', '').replace('-', '').replace(':', '').
            replace(';', '').replace('(', '').replace(')', '').replace('\"', '').replace('\'', '').toLowerCase().split(' ');        
    }

    var occurences = 0;

    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === word) {
            occurences++;
        }
    }
    
    document.getElementById("result3").innerHTML = 'Result Task 3: <span style="color:red;">' + occurences + '</span>';
}

//Task 04:
function numberOfElements(){
    var divs = document.getElementsByTagName("div").length;

    document.getElementById('result4').innerHTML = 'Result Task 4: <span style="color:red;">' + divs + '</span>';
}

//Task 05:
function appearanceCount() {
    var arrayString = document.getElementById('tb-numbers').value;
    var number = parseFloat(document.getElementById('tb-second').value);
    var arr = arrayString.split(' ');

    var appearance = 0;

    for (var i = 0; i < arr.length; i++) {
        if (parseFloat(arr[i]) === number) {
            appearance++;
        }
    }

    document.getElementById('result5').innerHTML = 'Result Task 5: <span style="color:red;">' + appearance + '</span>';
}

//Task 06:
function largerThanNeighbours() {
    var values = document.getElementById('tb-neighbours').value;
    var position = parseFloat(document.getElementById('tb-neighPosition').value);
    var arr = values.toString().split(' ');
    var num = parseFloat(arr[position]);
    var larger = false;

    if (position !== 0 && position !== arr.length - 1) {
        if (num > parseFloat(arr[position - 1]) && num > parseFloat(arr[position + 1])) {
            larger = true;
        }
    }

    document.getElementById('result6').innerHTML = 'Result Task 6: <span style="color: red;">' + larger + '</span>';
}

//Task 07:
function firstLarger() {
    var value = document.getElementById('elementOfArray').value;
    var arr = value.toString().split(' ');
    var result = -1.0;

    for (var i = 1; i < arr.length - 1; i++) {
        if (parseFloat(arr[i]) > parseFloat(arr[i - 1]) && parseFloat(arr[i]) > parseFloat(arr[i + 1])) {
            result = i;

            break;
        }
    }

    document.getElementById('result7').innerHTML = 'Result Task 7: <span style="color: red;">' + result + '</span>';
}
