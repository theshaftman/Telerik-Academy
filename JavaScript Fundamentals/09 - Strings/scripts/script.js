'use strict'

//Task 01: Reverse string
function reverseString() {
    var str = document.getElementById('reverseStr').value;

    document.getElementById('result1').innerHTML = 'Result Task 1: <span style="color: red;">' + str.split('').reverse().join('') + '</span>';
}

//console.log(reverseString('sample'));

//Task 02: Correct brackets
function correctBrackets() {
    var str = document.getElementById('expression').value;
    var openBrIndex = 0;
    var closeBrIndex = 1;
    var openBr = 0;
    var closeBr = 0;
    var result = true;

    for (var i = 0; i < str.length; i++) {
        // if (closeBrIndex < openBrIndex) {
        //     result = false;

        //     break;
        // }

        if (str[i] === '(') {
            openBrIndex = i;
            openBr++;
        } 
        if (str[i] === ')') {
            closeBrIndex = i;
            closeBr++;
        }
    }

    if (result) {
        if (openBr === closeBr) {
            result = true;
        } else {
            result = false;
        }
    }

    document.getElementById('result2').innerHTML = 'Result Task 2: <span style="color: red;">' + result + '</span>';
}

//Task 03: Sub-string in text
function substringInText() {
    var str = document.getElementById('textStr').value;
    var substr = document.getElementById('substrSearch').value;
    var repeated = 0;

    for (var i = 0; i < str.length; i++) {
        var rep = 0;

        if (((str.length - i) - substr.length) >= 0) {
            for (var sub = 0; sub < substr.length; sub++) {
                if (substr[sub].toLowerCase() === str[i + sub].toLowerCase()) {
                    rep++;
                }
            }

            if (rep === substr.length) {
                repeated++;
            }
        }
    }

    document.getElementById('result3').innerHTML = 'Result Task 3: <span style="color: red;">' + repeated + '</span>';
}

function substringIn(str, substr) {
    var repeated = 0;

    for (var i = 0; i < str.length; i++) {
        var rep = 0;

        if (((str.length - i) - substr.length) >= 0) {
            for (var sub = 0; sub < substr.length; sub++) {
                if (substr[sub].toLowerCase() === str[i + sub].toLowerCase()) {
                    rep++;
                }
            }

            if (rep === substr.length) {
                repeated++;
            }
        }
    }

    return repeated;
}

//Task 04: Parse tags
function parseTags() {
    var text = document.getElementById('getText').value;
    var objText = new String(text);
    objText = doMixCase(objText);
    objText = doUpcase(objText);
    objText = doLowCase(objText);
    
    function doUpcase(text) {
        var indexStart = text.indexOf('<upcase>');
        
        while (indexStart > -1) {
            var insedeText = text.substring(indexStart + 8, text.indexOf('</upcase>', indexStart))
            var upperText = insedeText.toUpperCase();
            text = text.replace(insedeText, upperText);
            indexStart = text.indexOf('<upcase>', indexStart + 1);
        }

        return text;
    }
    
    function doMixCase(text) {
        var indexStart = text.indexOf('<mixcase>');
        
        while (indexStart > -1) {
            var insedeText = text.substring(indexStart + 9, text.indexOf('</mixcase>', indexStart));
            var mixedText = new String(insedeText);
            
            for (var i = 0; i < mixedText.length; i++) {
                if(i % 2 == 0) {
                    mixedText = mixedText.replace(mixedText[i],mixedText[i].toUpperCase())
                } else {
                    mixedText = mixedText.replace(mixedText[i], mixedText[i].toLowerCase())
                }
            }

            text = text.replace(insedeText, mixedText);
            indexStart = text.indexOf('<mixcase>', indexStart + 1);
        }

        return text;
    }
    
    function doLowCase(text) {
        var indexStart = text.indexOf('<lowcase>');

        while (indexStart > -1) {
            var insedeText = text.substring(indexStart + 9, text.indexOf('</lowcase>', indexStart));
            var lowerText = insedeText.toLowerCase();
            text = text.replace(insedeText, lowerText);
            indexStart = text.indexOf('<lowcase>', indexStart + 1);
        }

        return text;
    }

    document.getElementById('result4').innerHTML = ' Result Task 4:\n ' + objText;
}

//Task 05: nbsp
function enterNbsp() {
    var str = document.getElementById('nbspText').value;
    var strArr = str.split(' ');

    for (var i = 0; i < strArr.length; i++) {
        if (i !== 0) {
            strArr[i] = '&amp;nbsp;' + strArr[i].slice(0);
        }
    }

    document.getElementById('result5').innerHTML = ' Result Task 5:\n ' + strArr.join('');
}

//Task 06: Extract text from HTML
function extraxtText() {
    var str = document.getElementById('extractText').value;
    var val = str.replace(/(<([^>]+)>)/ig, ""); //Remove tags
    val = val.replace(/(\r\n|\n|\r)/gm, ""); //Remove new lines

    document.getElementById('result6').value = ' Result Task 6:\n' + val.replace(/\s+/g," "); //Remove spaces
}

//Task 07: Parse URL
function parseURL() {
    var str = document.getElementById('emailSearch').value;
    var result = '';

    result += ' protocol: ' + str.substring(0, str.indexOf('/', 0) - 1) + ',\n' +
            ' server: ' + str.substring(str.indexOf('/', 0) + 2, str.indexOf('/', str.indexOf('/', 0) + 2)) + ',\n' +
            ' resource: ' + str.substring(str.indexOf('/', str.indexOf('/', 0) + 2), str.length);

    document.getElementById('result7').value = ' Result Task 7:\n' + result;
}


//Task 08: Replace tags
function replaceTags() {
    var str = document.getElementById('replaceTagsStr').value;
    var repeated = parseInt(substringIn(str.toString(), '<a href'));
    var result = str.toString();

    for (var i = 0; i < repeated; i++) {
        result = result.replace('<a href="', '[URL=').replace('">', ']').replace('</a>', '[/URL]');
    }

    document.getElementById('result8').value = ' Result Task 8:\n ' + result;
}

//Task 09: Extract e-mails
function extractEmails() {
    var str = document.getElementById('emailSearchStr').value;
    var emailArr = [];
    var index = 0;
    var strArr = str.split(' ');

    for (var i in strArr) {
        if (strArr[i].indexOf('@', 0) !== -1 && strArr[i].indexOf('.', strArr[i].indexOf('@', 0) + 3) !== -1) {
            emailArr[index] = strArr[i];
            index++;
        }
    }

    document.getElementById('result9').value = ' Result Task 9:\n [ ' + emailArr.join(', ') + ' ]';
}

//Task 10: Find palindromes
function findPalindromes() {
    var str = document.getElementById('palindromeSearchStr').value;

    var strRemoveSym = str.split('.').join('').split(',').join('').split('!').join('').
        split('?').join('').split(':').join('').split('-').join('').split('(').join('').
        split(')').join('').split(']').join('').split('[').join('').split('"').join('');
    var strArr = strRemoveSym.split(' ');
    var result = [];
    var index = 0;

    for (var i in strArr) {
        if (CheckStr(strArr[i].toLowerCase())) {
            result[index] = strArr[i];
            index++;
        }
    }

    function CheckStr(string) {
        var len = (string.length / 2).toString().substring(0, (string.length / 2).toString().indexOf('.', 0));

        if (len === "") {
            len = (string.length / 2).toString();
        }


        for (var i = 0; i < parseInt(len); i++) {
            if (string[i] !== string[string.length - 1 - i]) {
                return false;
            }
        }

        return true;
    }

    document.getElementById('result10').value = ' Result Task 10:\n ' + result.join(', ');
}

//Task 11: String format
function stringFormatFunction() {
    document.getElementById('result11').value = ' Result Task 11:';

    function stringFormat(string) {
        var stringCopy = string;
        var argmnt = substringIn(string, '{');
        var argmtArr = [];
        var index = 0;

        for (var i = 0; i < parseInt(argmnt); i++) {
            index = parseInt(stringCopy.substring(stringCopy.toString().indexOf('{', 0) + 1, stringCopy.toString().indexOf('{', 0) + 2));
            argmtArr[index] = arguments[index + 1];

            stringCopy = stringCopy.replace('{', '[');
        }

        for (var j = 0; j < parseInt(argmnt); j++) {
            index = string.substring(string.toString().indexOf('{', 0) + 1, string.toString().indexOf('{', 0) + 2);
            string = string.replace('{' + index + '}', argmtArr[index]);
        }

        document.getElementById('result11').value += '\n ' + string;
    }

    var str = stringFormat('Hello {0}!', 'Peter');
    //console.log(str);

    var frmt = '{0}, {1}, {0} text {2}';
    str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
    //console.log(str);
}

//Task 12: Generate list
function generateList() {
    var people = [{name: 'Peter', age: 14}];
    var tmpl = document.getElementById('list-item');
    var repeated = substringIn(tmpl.innerHTML, '{');
    var result = tmpl.innerHTML.toString();

    for (var i = 0; i < parseInt(repeated); i++) {
        var indexStart = result.indexOf('{', 0) + 1;
        var endIndex = result.indexOf('}', 0);

        var change = result.substring(indexStart, endIndex);

        for (var prop in people) {
            for (var peopleProp in people[prop]) {
                if (peopleProp.toString() === change.toString()) {
                    result = result.replace('-{', '').replace(change.toString(), people[prop][peopleProp]).replace('}-', '');
                }
            }
        }
    }

    var repeat = parseInt(substringIn(result, '>'));
    var checkResult = result;
    var ind = 0;

    for (var j = 0;j < checkResult.length; j++) {
        if (checkResult[j] === '>') {
            ind = j;
        }
    }

    result = result.slice(0, result.indexOf('<')) + '<ul><li>' + result.substring(result.indexOf('<', 0), result.indexOf('>', ind)) + '></li></ul>';
    tmpl.innerHTML = result;
}