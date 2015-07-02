// Task 01:
function literals() {
	var booleanType = true;
	var resultA = "";
	console.log("Bool: " + booleanType);
	resultA += "Bool: " + booleanType + "<br />";

	var integer = 5;
	console.log("Integer: " + integer);
	resultA += "Integer: " + integer + "<br />";

	var doubleNumber = 8.75;
	console.log("Double: " + doubleNumber);
	resultA += "Double: " + doubleNumber + "<br />";

	var charSymbol = 'a';
	console.log("Char: '" + charSymbol + "'");
	resultA += "Char: '" + charSymbol + "'<br />";

	var text = "\"Hello, World!\"";
	console.log("String: " + text);
	resultA += "String: " + text + "<br />";

	var undefinedType;
	console.log("Undefined: " + undefinedType);
	resultA += "Undefined: " + undefinedType + "<br />";

	var nullableType = null;
	console.log("Null: " + nullableType);
	resultA += "Null: " + nullableType + "<br />";

	var integerObject = new Number(5);
	console.log("Integer object: " + integerObject);
	resultA += "Integer object: " + integerObject + "<br />";

	document.getElementById("result1").innerHTML = '<spam style="color: red;">' + resultA + '</spam>';
}

console.log("Task 01:");
literals();

// Task 02:
function quotedText() {
    var quotedString = "\'\"How You Doin\'?\", Joey said\'";

    console.log(quotedString);
    document.getElementById("result2").innerHTML = '<spam style="color: red;">' + quotedString + '</spam>';
}

console.log("\nTask 02:");
quotedText();

// Task 03:
function typeofVariables() {
	var resultA = "";

    var booleanType = true;
    console.log("Bool => " + typeof(booleanType));
	resultA += "Bool => " + typeof(booleanType) + "<br />";

    var integer = 5;
    console.log("Integer => " + typeof(integer));
	resultA += "Integer => " + typeof(integer) + "<br />";

    var doubleNumber = 8.75;
    console.log("Double => " + typeof(doubleNumber));
	resultA += "Double => " + typeof(doubleNumber) + "<br />";

    var charSymbol = 'a';
    console.log("Char => " + typeof(charSymbol));
	resultA += "Char => " + typeof(charSymbol) + "<br />";

    var text = "Hello, World!";
    console.log("String => " + typeof(text));
	resultA += "String => " + typeof(text) + "<br />";

    var integerObject = new Number(5);
    console.log("Integer object => " + typeof(integerObject));
	resultA += "Integer object => " + typeof(integerObject) + "<br />";

    var arr = [5];
    console.log("Array => " + typeof(arr));
	resultA += "Array => " + typeof(arr) + "<br />";

    var notNumber = NaN;
    console.log("NaN => " + typeof(notNumber));
	resultA += "NaN => " + typeof(notNumber) + "<br />";

    document.getElementById("result3").innerHTML = '<spam style="color: red;">' + resultA + '</spam>';
}

console.log("\nTask 03:");
typeofVariables();

//Task 04
function typeofNull() {
	var result = "";

    var nullableType = null;
    console.log("Null => " + typeof(nullableType));
	result += "Null => " + typeof(nullableType) + "<br />";

    var undefinedType;
    console.log("Undefined => " + typeof(undefinedType));
	result += "Undefined => " + typeof(undefinedType) + "<br />";

    document.getElementById("result4").innerHTML = '<spam style="color: red;">' + result + '</spam>';
}

console.log("\nTask 04:");
typeofNull();