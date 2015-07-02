'use strict'

var person = [
    { firstname: 'Ivan', lastname: 'Ivanov', age: 23, gender: false },
    { firstname: 'Ivana', lastname: 'Ivanova', age: 14, gender: true },
    { firstname: 'Bai', lastname: 'Todor', age: 17, gender: false },
    { firstname: 'George', lastname: 'Winsley', age: 18, gender: false },
    { firstname: 'Mariya', lastname: 'Todorova', age: 14, gender: true },
    { firstname: 'Ivelina', lastname: 'Ivelinova', age: 15, gender: true },
    { firstname: 'Teodora', lastname: 'Teodorova', age: 14, gender: true },
    { firstname: 'Todor', lastname: 'Ivanov', age: 16, gender: false },
    { firstname: 'Gabriel', lastname: 'Todorov', age: 20, gender: false },
    { firstname: 'Krisia', lastname: 'Georgieva', age: 19, gender: true }
];

//Task 01: Make person
function makePerson() {
    var person = [];
    var index = 0;

    function createPerson(fName, lName, ageInt, genderBool) {
        person[index] = [
            this.firstname = fName,
            this.lastname = lName,
            this.age = ageInt,
            this.gender = genderBool
        ];

        index++;
    }

    var newPerson = new createPerson('Ivan', 'Ivanov', 13, false);
    newPerson = new createPerson('Ivana', 'Ivanova', 14, true);
    newPerson = new createPerson('Bai', 'Todor', 17, false);
    newPerson = new createPerson('George', 'Winsley', 18, false);
    newPerson = new createPerson('Mariya', 'Todorova', 14, true);
    newPerson = new createPerson('Ivelina', 'Ivelinova', 15, true);
    newPerson = new createPerson('Teodora', 'Teodorova', 14, true);
    newPerson = new createPerson('Todor', 'Ivanov', 16, false);
    newPerson = new createPerson('Gabriel', 'Todorov', 20, false);
    newPerson = new createPerson('Krisia', 'Georgieva', 19, true);

    return person;
}

//console.log(makePerson());

//Task 02: People of age
function peopleOfAge() {
    var result = [];
    var index = 0;

    for (var prop in person) {
        for (var personProp in person[prop]) {
            if (personProp === 'age') {
                if (person[prop][personProp] >= 18) {
                    result[index] = person[prop];
                    index++;
                }
            }
        }
    }

    console.log(index);
    return result;
}

//console.log(peopleOfAge());

//Task 03: Underage people
function underagePeople() {
    var result = [];
    var index = 0;

    for (var prop in person) {
        for (var personProp in person[prop]) {
            if (personProp === 'age') {
                if (person[prop][personProp] < 18) {
                    result[index] = person[prop];
                    index++;
                }
            }
        }
    }

    return result;
}

//console.log(underagePeople());

//Task 04: Average age of females
function averageAgeOfFemales() {
    var age = 0;
    var number = 0;

    for (var prop in person) {
        for (var personProp in person[prop]) {
            if (personProp === 'gender') {
                if (person[prop][personProp] === true) {
                    age += person[prop].age;
                    number++;
                }
            }
        }
    }

    return age / number;
}

//console.log(averageAgeOfFemales());

//Task 05: Youngest person
function youngestPerson() {
    var smaller = person[0].age;

    for (var prop in person) {
        if (person[prop].age < smaller) {
            smaller = person[prop].age;
        }
    }

    var result = '';

    for (var property in person) {
        if (person[property].age === smaller) {
            result += person[property].firstname + ' ' + person[property].lastname + '\n';
        }
    }

    return result;
}

//console.log(youngestPerson());

//Task 06: Group people
function groupPeople() {
    var result = [];

    Array.prototype.sortBy = function(p) {
        return this.slice(0).sort(function(a,b) {
            return (a[p] > b[p]) ? 1 : (a[p] < b[p]) ? -1 : 0;
        });
    }

    result = person.sortBy('firstname');

    return result;
}

console.log(groupPeople());