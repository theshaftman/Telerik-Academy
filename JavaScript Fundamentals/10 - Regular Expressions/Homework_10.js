//Task 01: Format with placeholders
String.prototype.format = function(options) {
    var option,
        regex,
        formatted = this;
    for (option in options) {
        regex = new RegExp('#{' + option + '}', 'g');
        formatted = formatted.replace(regex, options[option]);
    }

    return formatted;
};

var options = {name: 'John'};
// console.log('Hello, there! Are you #{name}?'.format(options));

var options = {name: 'John', age: 13};
// console.log('My name is #{name} and I am #{age}-years-old'.format(options));

//Task 02: HTML binding
String.prototype.bind = function(output, parameters) {
    var regexContent,
        regexHref,
        regexClass,
        prop;
    output = this;

    for (prop in parameters) {
        regexContent = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
        regexHref = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
        regexClass = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');

        output = output.replace(regexContent, function(element, openingTag, content, closingTag) {
            return openingTag + parameters[prop] + closingTag;
        });

        output = output.replace(regexHref, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' href="' + parameters[prop] + '">';
        });

        output = output.replace(regexClass, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' class="' + parameters[prop] + '">';
        });
    }

    return output;
};

console.log('<div data-bind-content="name"></div>'.bind('', {name: 'Steven'}));
console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'.bind('', {name: 'Elena', link: 'http://telerikacademy.com'}));
