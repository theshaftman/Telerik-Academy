'use strict'

//Task 01: Planar coordinates
function PlanarCoordinates() {
    var x1 = parseFloat(document.getElementById('x1').value);
    var y1 = parseFloat(document.getElementById('y1').value);
    var x2 = parseFloat(document.getElementById('x2').value);
    var y2 = parseFloat(document.getElementById('y2').value);
    var x3 = parseFloat(document.getElementById('x3').value);
    var y3 = parseFloat(document.getElementById('y3').value);

    var length = {
        lineLengthAtoB: countDistance(x1, y1, x2, y2),
        lineLengthBtoC: countDistance(x2, y2, x3, y3),
        lineLengthAtoC: countDistance(x1, y1, x3, y3)
    }

    function countDistance(varX1, varY1, varX2, varY2) {
        var result = Math.sqrt(((varX2 - varX1) * (varX2 - varX1)) +
            ((varY2 - varY1) * (varY2 - varY1)));

        return result;
    }

    var resultAtoB = Count(length.lineLengthAtoB.toString());
    var resultBtoC = Count(length.lineLengthBtoC.toString());
    var resultAtoC = Count(length.lineLengthAtoC.toString());

    function Count(str) {
        var i;
        var index = str.length;

        for (i = 0; i < str.length; i++) {
            if (str[i] === '.'.toString()) {
                index = i + 4;

                break;
            }
        }

        return str.substring(0, index);
    }

    var form = formTriangle(parseFloat(resultAtoB), parseFloat(resultBtoC), parseFloat(resultAtoC));

    function formTriangle(a, b, c) {
        var biggest = a;
        var second = b;
        var third = c;
        if (b > a && b > c) {
            biggest = b;
            second = a;
        } else if (c > a && c > b) {
            biggest = c;
            second = a;
        }

        var val = second + third;

        if (val > biggest) {
            return true;
        } else {
            return false;
        }
    }

    var endResult = 'Distanance:<br />A to B = <span style="color: red;">' + resultAtoB + 
        '</span><br />B to C = <span style="color: red;">' + resultBtoC + '</span><br />A to C = <span style="color: red;">' + 
        resultAtoC + '</span><br />';
    endResult += 'Can the lines form a triangle? <span style="color: red;">' + form + '</span>';

    document.getElementById('result1').innerHTML = '<h4>Result Task 1:</h4> ' + endResult;
}

//Task 02: Remove elements
function removeElements() {
    var array = document.getElementById('array').value;
    var remove = document.getElementById('removeFromArray').value;
    var arr = array.split(' ');
    var removeArr = remove.split(' ');
    var index = removeArr.length - 1;

    for (var i = arr.length - 1; i >= 0; i--) {
        if (arr[i] === removeArr[index]) {
            arr.splice(i, 1);
            index--;
        }
    }

    document.getElementById('result2').innerHTML = '<h4>Result Task 2:</h4> Left array -> <span style="color: red;">' + arr + '</span>';
}

//removeElements([1,2,1,4,1,3,4,1,111,3,2,1,'1'], [2,4,3,4,111,3,2,'1']);

//Task 03: Deep copy
function deepCopy() {
    var inputObj = [ 
        { name: 'Hello', age: 1 },
        { name: 'Bye', age: -1 }
    ];
    var copiedObj = {};

    for (var prop in inputObj) {
        copiedObj[prop] = inputObj[prop];

        for (var objProp in inputObj[prop]) {
            copiedObj[prop][objProp] = inputObj[prop][objProp];
        }
    }

    var result = 'Input object: <br /><span style="color: red;">' + ObjPrint(inputObj) + 
        '</span>Copied object:<br /><span style="color: red;">' + ObjPrint(copiedObj) + '</span>';

    function ObjPrint(obj) {
        var str = "";

        for (var prop in obj) {
            for (var objProp in obj[prop]) {
                str += '[' + prop + '] ' + objProp + ': ' + obj[prop][objProp] + '<br />';
            }
        }

        return str;
    }

    document.getElementById('result3').innerHTML = '<h4>Result Task 3:</h4> ' + result;
}

//Task 04: Has property
function hasProperty() {
    var property = document.getElementById('property').value;
    var result = false;

    var obj = {
        name: 'Bay Ivan',
        gender: 'm',
        age: -1,
        town: 'There',
        education: 'Some'
    };

    for (var prop in obj) {
        if (prop === property) {
            result = true;

            break;
        }
    }

    document.getElementById('result4').innerHTML = '<h4>Result Task 4:</h4> <span style="color: red;">' + result + '</span>';
}

//Task 05: Youngest person
var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Gosho', lastname: 'Ivanov', age: 81 },
    { firstname: 'Todor', lastname: 'Ivanov', age: 13 },
    { firstname: 'Bay', lastname: 'Petrov', age: 32 },
    { firstname: 'Todor', lastname: 'Ivan', age: 32 }
];

function youngestPerson() {
    var smaller = 0;

    for (var prop in people) {
        if (people[prop].age < people[smaller].age) {
            smaller = prop;
        }
    }

    var fullName = people[smaller].firstname + ' ' + people[smaller].lastname;
    
    document.getElementById('result5').innerHTML = '<h4>Result Task 5:</h4> <span style="color: red;">' + fullName + '</span>';
}

//Task 06: Group
function groupObj() {
    var sortBy = document.getElementById('sortBy').value;

    function group(peopleObj, property) {
        var objLength = CheckObjLength(peopleObj);
        var resultStr = new Array();
        var index = 0;

        for (var prop in peopleObj) {
            for (var peopleObjProp in peopleObj[prop]) {

                if (peopleObjProp === property) {
                    for (var j = 0; j <= objLength; j++) {
                        if (peopleObj[j][peopleObjProp] === peopleObj[prop][peopleObjProp]) {
                            var str = '';

                            for (var part in peopleObj[j]) {
                                str += part.toString() + ': ' + peopleObj[j][part].toString() + ', ';
                            }

                            str = str.substring(0, str.length - 2);

                            if (CheckIt(resultStr, str)) {
                                resultStr[index] = str;
                                index++;
                            }
                        }
                    }
                }
            }
        }

        function CheckIt(arr, str) {
            var i;

            for (i = 0; i < arr.length; i++) {
                if (arr[i] === str) {
                    return false;
                }
            }

            return true;
        }

        function CheckObjLength(obj) {
            for (var i in obj) { }

            return i;
        }

        return resultStr.join('<br />');
    }

    var res = '///Sort by ' + sortBy + '///<br />' + group(people, sortBy);

    document.getElementById('result6').innerHTML = '<h4>Result Task 6:</h4> ' + res;
}
