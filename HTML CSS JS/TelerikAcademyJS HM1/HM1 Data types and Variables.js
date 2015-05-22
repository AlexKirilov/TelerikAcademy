
var intLit = 5,
    floatLit = 8.05,
    boolLit = true,
    stringLit = "clap",
    objectLit = {
        name: 'Pesho',
        age: 22
    };
var objectLit = [stringLit, intLit, floatLit, isTrue];

    arrayLit = [1, 2, 3],
    functionLit = function() {
        alert('This is the function literal');
    };
    
    
console.log(arrayAllInOne);

var joeysWords = "'How you doin'?', Joey said.";
console.log(joeysWords);

joeysWords = '\'How you doin\'?\', Joey said.';
console.log("Joey's words again (using slashes): ", joeysWords);
console.log("typeof joeysWords:", typeof (joeysWords));

var arrayOfVariables = [
    intLit,
    floatLit,
    boolLit,
    stringLit,
    objectLit,
    arrayLit,
    functionLit,
    joeysWords
];

console.log('Task 3: \n');

for (var i = 0; i < arrayOfVariables.length - 1; i += 1) {
    getTypeOf(arrayOfVariables[i], "task3");
    console.log('Type of ' + arrayOfVariables[i] + ' is: ' + typeof(arrayOfVariables[i]));
}

var undefinedVariable;
var nullVariable = null;
console.log("This is an undefined variable:", undefinedVariable);
console.log("This is nullVariable:", nullVariable);