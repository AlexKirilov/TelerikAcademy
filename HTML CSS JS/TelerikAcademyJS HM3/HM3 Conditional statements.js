$(document).ready(function () {

    //DOM durvoto na html faila
    var mainHTML = '<div id="nav">' +
            '<ul>' +
            '<li id="task1"> Exchange if greater </li>' +
            '<li id="task2"> Multiplication Sign </li>' +
            '<li id="task3"> The biggest of Three </li>' +
            '<li id="task4"> Sort 3 numbers </li>' +
            '<li id="task5"> Digit as word </li>' +
            '<li id="task6"> Quadratic equation </li>' +
            '<li id="task7"> The biggest of five numbers </li>' +
            '<li id="task8"> Number as words </li>' +
            '</ul>' +
            '</div>' +
            '<div id="tasks">' +
            '</div>';

    //Vizualizira HTML-a
    $('#main-container-HomeWorkJS').html(mainHTML);
    //Style of the DOM  
    $('#nav').css({"background": "linear-gradient(270deg, grey, #000000", "width": "160px", "float": "left"});
    $('#nav > ul > li').css({"padding": "5px", "color": "white",
        "overflow": "hidden", "margin-left": "-40px", "width": "150px",
        "border-bottom": "2px solid gold"});

    $('#tasks').css({"border": "1px solid black", "border-radius": "10px",
        "margin-left": "170px", "padding-left": "20px", "width": "500px"});


    //Hover na Li-tata
    $("#nav > ul > li").mouseenter(function () {
        $(this).css({"color": hoverColor});
    }).mouseleave(function () {
        $(this).css({"color": "white"});
    });

    var activeColor = "lawngreen";
    var hoverColor = "yellow";

    var problem1 = '<p> Enter two double variables a and b  </p>' +
            'a: <input type="text" name="inputP1" class="value1" size="5" />' +
            'b: <input type="text" name="inputP1" class="value2" size="5" />' +
            '<input type="submit" name="button" id="P1_submit" />' +
            '<p id="resultP1"> </p>';

    var problem2 = '<p> Please input three real numbers</p>' +
            'a: <input type="text" class="value1" size="5" />' +
            'b: <input type="text" class="value2" size="5" />' +
            'c: <input type="text" class="value3" size="5" />' +
            '<input type="submit" name="button" id="P2_submit" />' +
            '<p id="resultP2"> </p>';

    var problem3 = '<p> Please input width and height to calculate rectangle`s area</p>' +
            'a: <input type="text" class="value1" size="5" />' +
            'b: <input type="text" class="value2" size="5" />' +
            'c: <input type="text" class="value3" size="5" />' +
            '<input type="submit" name="button" id="P3_submit" />' +
            '<p id="resultP3"> </p>';

    var problem4 = '<p> Please insert three integer. </p>' +
            'a: <input type="text" class="value1" size="5" />' +
            'b: <input type="text" class="value2" size="5" />' +
            'c: <input type="text" class="value3" size="5" />' +
            '<input type="submit" name="button" id="P4_submit" />' +
            '<p id="resultP4"> </p>';

    var problem5 = '<p> Please enter a digit </p>' +
            '<input type="text" name="inputP5" class="value1" />' +
            '<input type="submit" name="button" id="P5_submit" />' +
            '<p id="resultP5"> </p>';

    var problem6 = '<p> Please enter coefficients a, b and c of a quadratic equation. </p>' +
            'a: <input type="text" class="value1" size="5" />' +
            'b: <input type="text" class="value2" size="5" />' +
            'c: <input type="text" class="value3" size="5" />' +
            '<input type="submit" id="P6_submit" />' +
            '<p id="resultP6"> </p>';

    var problem7 = '<p> The biggest of five numbers. </p>' +
            'a: <input type="text" class="value1" size="5" />' +
            'b: <input type="text" class="value2" size="5" />' +
            'c: <input type="text" class="value3" size="5" />' +
            'd: <input type="text" class="value4" size="5" />' +
            'e: <input type="text" class="value5" size="5" />' +
            '<input type="submit" id="P7_submit" />' +
            '<p id="resultP7"> </p>';

    var problem8 = '<p> Enter a number between (0 , 999). </p>' +
            '<input type="text"  class="value1" size="6" />' +
            '<input type="submit" id="P8_submit" />' +
            '<p id="resultP8"> </p>';


    // OnClick on the navigation buttons
    //Task1
    $(document).on('click', '#task1', function () {
        $('#tasks').html(problem1);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task1').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P1_submit').css({"margin-left": "10px"});
        $('.value1').css({"margin-right": "10px"});
    });

    //Calculation functions
    var result, valueA, valueB, valueC, valueD, valueE;
    //Task1
    $(document).on('click', '#P1_submit', function () {
        valueA = $('.value1').val();
        valueB = $('.value2').val();

        if (valueA > valueB) {
            $('#resultP1').html("Result: " + valueB + " " + valueA);
        } else {
            $('#resultP1').html("Result: " + valueA + " " + valueB);
        }
    });

    // OnClick on the navigation buttons
    //Task2
    $(document).on('click', '#task2', function () {
        $('#tasks').html(problem2);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task2').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P2_submit').css({"margin-left": "10px"});
        $('.value1').css({"margin-right": "10px"});
        $('.value2').css({"margin-right": "10px"});
    });

    //Calculation functions
    //Task2
    $(document).on('click', '#P2_submit', function () {
        valueA = $('.value1').val();
        valueB = $('.value2').val();
        valueC = $('.value3').val();
        result = 0;
        if (valueA < 0)
            result++;
        if (valueB < 0)
            result++;
        if (valueC < 0)
            result++;

        if (result == 1 || result == 3)
            result = '-';
        else if (result == 0 || result == 2)
            result = '+';
        $('#resultP2').html("Result: " + result);
        if (valueA == 0 || valueB == 0 || valueC == 0) {
            result = 0;
            $('#resultP2').html("Result: " + result);
        }
    });

    // OnClick on the navigation buttons
    $(document).on('click', '#task3', function () {
        $('#tasks').html(problem3);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task3').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#width_Input').css({"margin-right": "10px"});
        $('.value1').css({"margin-right": "10px"});
        $('.value2').css({"margin-right": "10px"});
    });

    //Calculation functions
    //Task3
    $(document).on('click', '#P3_submit', function () {
        valueA = $('.value1').val();
        valueB = $('.value2').val();
        valueC = $('.value3').val();
        //Nested if po uslovie
        if (valueA > 0 || valueB > 0 || valueC > 0) {
            if (valueA > valueB) {
                if (valueA > valueC) {
                    result = valueA;
                }
                else {
                    result = valueC;
                }
            }
            else if (valueB > valueC) {
                result = valueB;
            } else {
                result = valueC;
            }
        } else {
            if (valueA < valueB) {
                if (valueA < valueC) {
                    result = valueA;
                }
                else {
                    result = valueC;
                }
            }
            else if (valueB < valueC) {
                result = valueB;
            } else {
                result = valueC;
            }
        }
        $('#resultP3').html("Biggest: " + result);
    });

    // OnClick on the navigation buttons
    //Task4
    $(document).on('click', '#task4', function () {
        $('#tasks').html(problem4);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task4').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P4_submit').css({"margin-left": "10px"});
        $('.value1').css({"margin-right": "10px"});
        $('.value2').css({"margin-right": "10px"});
    });

    //Calculation functions
    //Task4
    $(document).on('click', '#P4_submit', function () {
        var a = $('.value1').val() * 1;
        var b = $('.value2').val() * 1;
        var c = $('.value3').val() * 1;
        var sorted;
        if (a >= b) {
            if (b >= c) {
                sorted = a + ' ' + b + ' ' + c;
            } else {
                if (c > a) {
                    sorted = c + ' ' + a + ' ' + b;
                } else {
                    sorted = a + ' ' + c + ' ' + b;
                }
            }
        } else {
            if (b >= c) {
                if (a >= c) {
                    sorted = b + ' ' + a + ' ' + c;
                } else {
                    sorted = b + ' ' + c + ' ' + a;
                }
            } else {
                sorted = c + ' ' + b + ' ' + a;
            }
        }
        $('#resultP4').html("Result: " + sorted);
    });

    //Task5
    // OnClick on the navigation buttons
    $(document).on('click', '#task5', function () {
        $('#tasks').html(problem5);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task5').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P5_submit').css({"margin-left": "10px"});
        $('.value1').css({"margin-right": "10px"});
    });

    //Task5
    //Calculation functions
    $(document).on('click', '#P5_submit', function () {
        result = 'not a digit';
        valueA = $('.value1').val();
        switch (valueA) {
            case '0':
                result = "Zero";
                break;
            case '1':
                result = "One";
                break;
            case '2':
                result = "Two";
                break;
            case '3':
                result = "Three";
                break;
            case '4':
                result = "Four";
                break;
            case '5':
                result = "Five";
                break;
            case '6':
                result = "Six";
                break;
            case '7':
                result = "Seven";
                break;
            case '8':
                result = "Eight";
                break;
            case '9':
                result = "Nine";
                break;
        }

        $('#resultP5').html("Result: " + result);
    });

    //Task6
    // OnClick on the navigation buttons
    $(document).on('click', '#task6', function () {
        $('#tasks').html(problem6);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task6').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P6_submit').css({"margin-left": "10px"});
        $('.value1').css({"margin-right": "10px"});
        $('.value2').css({"margin-right": "10px"});
    });
    //Task6
    //Calculation functions
    $(document).on('click', '#P6_submit', function () {
        valueA = $('.value1').val() * 1;
        valueB = $('.value2').val() * 1;
        valueC = $('.value3').val() * 1;
        var Desc, x1, x2, x;
        Desc = valueB * valueB - 4 * valueA * valueC;
        x = -valueB / (2 * valueA);
        x1 = (-valueB - Math.sqrt(Desc)) / (2 * valueA);
        x2 = (-valueB + Math.sqrt(Desc)) / (2 * valueA);

        if (Desc < 0) {
            result = valueA + "x^2 + " + valueB + "x + " + valueC + " has no real roots.";
        } else {
            if (Desc === 0) {
                result = valueA + "x^2 + " + valueB + "x + " + valueC + " has one real root x= " + x;
            } else {
                result = valueA + "x^2 + " + valueB + "x + " + valueC + " has two real roots x1= " + x1 + " and x2= " + x2;
            }
        }

        $('#resultP6').html(result);
    });

    //Task7
    // OnClick on the navigation buttons
    $(document).on('click', '#task7', function () {
        $('#tasks').html(problem7);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task7').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P7_submit').css({"margin-top": "20px"});
        $('.value1').css({"margin-right": "10px"});
        $('.value2').css({"margin-right": "10px"});
        $('.value3').css({"margin-right": "10px"});
        $('.value4').css({"margin-right": "10px"});
    });

    //Task7
    //Calculation functions
    $(document).on('click', '#P7_submit', function () {
        valueA = $('.value1').val() * 1;
        valueB = $('.value2').val() * 1;
        valueC = $('.value3').val() * 1;
        valueD = $('.value4').val() * 1;
        valueE = $('.value5').val() * 1;
        var max = valueA;
        if (valueB > max)
            max = valueB;
        if (valueC > max)
            max = valueC;
        if (valueD > max)
            max = valueD;
        if (valueE > max)
            max = valueE;

        $('#resultP7').html("The Biggest is: " + max);
    });

    //Task8
    // OnClick on the navigation buttons
    $(document).on('click', '#task8', function () {
        $('#tasks').html(problem8);
        $("#nav > ul > li").css({"color": "white"}).mouseleave(function () {
            $(this).css({"color": "white"});
        });
        $('#task8').css("color", activeColor).mouseleave(function () {
            $(this).css({"color": activeColor});
        });
        $('#P8_submit').css({"margin-left": "10px"});
    });

    //Task8
    //Calculation functions
    $(document).on('click', '#P8_submit', function () {
        valueA = $('.value1').val() * 1;
        if (valueA < 0 || valueA > 999){
            result = 'out of the range';
            console.log(result);
        }
        else {
            var count = 0;
            var strlen = valueA.toString();
            count = strlen.length * 1;

            if (count == 1) {
                result = Digit(valueA);
            } else if (count == 2) {
                if (valueA <= 19 && valueA > 9) {
                    result = Teens(valueA);
                } else if (valueA > 19 && valueA < 100) {
                    result = Tenths(parseInt(strlen[0])) + " " + Digit(parseInt(strlen[1]));
                }
            } else if (count == 3) {
                if (strlen[0] != 0) {
                    if (strlen[1] == 0 && strlen[2] == 0) {
                        result = Digit(parseInt(strlen[0])) + " hundred";
                    }
                    else if(strlen[1] == 0){
                       result = Digit(parseInt(strlen[0])) + " hundred and " + Digit(parseInt(strlen[2])); ; 
                    }
                    else if(strlen[1] == 1){
                        var num = strlen[1]+strlen[2];
                        result = Digit(parseInt(strlen[0])) + " hundred and " + Teens(parseInt(num));
                    }else{
                        result = Digit(parseInt(strlen[0])) + " hundred and " + Tenths(parseInt(strlen[1])) + " "+  Digit(parseInt(strlen[2]));
                    }
                }
            }
        }

        $('#resultP8').html(result);

    });

    function Digit(digit) {

        switch (digit) {
            case 0:
                return "zero";
                break;
            case 1:
                return "one";
                break;
            case 2:
                return "two";
                break;
            case 3:
                return "three";
                break;
            case 4:
                return "four";
                break;
            case 5:
                return "five";
                break;
            case 6:
                return "six";
                break;
            case 7:
                return "seven";
                break;
            case 8:
                return "eight";
                break;
            case 9:
                return "nine";
                break;
        }
    }
    function Teens(teens) {
        switch (teens) {
            case 10:
                return "ten";
            case 11:
                return "eleven";
            case 12:
                return "twelve";
            case 13:
                return "thirteen";
            case 14:
                return "fourteen";
            case 15:
                return "fifteen";
            case 16:
                return "sixteen";
            case 17:
                return "seventeen";
            case 18:
                return "eighteen";
            case 19:
                return "nineteen";
        }
    }
    function Tenths(digit) {
        switch (digit) {
            case 2:
                return "twenty";
            case 3:
                return "thirty";
            case 4:
                return "fourty";
            case 5:
                return "fifty";
            case 6:
                return "sixty";
            case 7:
                return "seventy";
            case 8:
                return "eighty";
            case 9:
                return "ninety";
        }
    }

});



/*Problem 1. Exchange if greater
 
 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 Examples:
 
 a	b	result
 5	2	2 5
 3	4	3 4
 5.5	4.5	4.5 5.5
 Problem 2. Multiplication Sign
 
 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 Examples:
 
 a	b	c	result
 5	2	2	+
 -2	-2	1	+
 -2	4	3	-
 0	-2.5	4	0
 -1	-0.5	-5.1	-
 Problem 3. The biggest of Three
 
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 Examples:
 
 a	b	c	biggest
 5	2	2	5
 -2	-2	1	1
 -2	4	3	4
 0	-2.5	5	5
 -0.1	-0.5	-1.1	-0.1
 Problem 4. Sort 3 numbers
 
 Sort 3 real values in descending order.
 Use nested if statements.
 Note: Don’t use arrays and the built-in sorting functionality.
 
 Examples:
 
 a	b	c	result
 5	1	2	5 2 1
 -2	-2	1	1 -2 -2
 -2	4	3	4 3 -2
 0	-2.5	5	5 0 -2.5
 -1.1	-0.5	-0.1	-0.1 -0.5 -1.1
 10	20	30	30 20 10
 1	1	1	1 1 1
 Problem 5. Digit as word
 
 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 Examples:
 
 digit	result
 2	two
 1	one
 0	zero
 5	five
 -0.1	not a digit
 hi	not a digit
 9	nine
 10	not a digit
 Problem 6. Quadratic equation
 
 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
 
 Examples:
 
 a	b	c	roots
 2	5	-3	x1=-3; x2=0.5
 -1	3	0	x1=3; x2=0
 -0.5	4	-8	x1=x2=4
 5	2	8	no real roots
 Problem 7. The biggest of five numbers
 
 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 Examples:
 
 a	b	c	d	e	biggest
 5	2	2	4	1	5
 -2	-22	1	0	0	1
 -2	4	3	2	0	4
 0	-2.5	0	5	5	5
 -3	-0.5	-1.1	-2	-0.1	-0.1
 Problem 8. Number as words
 
 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 Examples:
 
 numbers	number as words
 0	Zero
 9	Nine
 10	Ten
 12	Twelve
 19	Nineteen
 25	Twenty five
 98	Ninety eight
 98	Ninety eight
 273	Two hundred and seventy three
 400	Four hundred
 501	Five hundred and one
 617	Six hundred and seventeen
 711	Seven hundred and eleven
 999	Nine hundred and ninety nine
 */