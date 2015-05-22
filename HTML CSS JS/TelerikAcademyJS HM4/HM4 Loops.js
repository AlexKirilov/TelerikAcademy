$(document).ready(function () {

    //DOM durvoto na html faila
    var mainHTML = '<div id="nav">' +
            '<ul>' +
            '<li id="task1"> Numbers </li>' +
            '<li id="task2"> Numbers not divisible </li>' +
            '<li id="task3"> Min/Max of sequence </li>' +
            '<li id="task4"> Lexicographically smallest </li>' +
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
        "margin-left": "170px", "padding-left": "20px", "padding-right": "20px", "width": "400px"});


    //Hover na Li-tata
    $("#nav > ul > li").mouseenter(function () {
        $(this).css({"color": hoverColor});
    }).mouseleave(function () {
        $(this).css({"color": "white"});
    });

    var activeColor = "lawngreen";
    var hoverColor = "yellow";

    var problem1 = '<p> Enter an integer for N  </p>' +
            'N: <input type="text" name="inputP1" class="value1" size="5" />' +
            '<input type="submit" name="button" id="P1_submit" />' +
            '<p id="resultP1"> </p>';

    var problem2 = '<p> Please enter an integer for N</p>' +
            'N: <input type="text" class="value1" size="5" />' +
            '<input type="submit" name="button" id="P2_submit" />' +
            '<p id="resultP2"> </p>';

    var problem3 = '<p> Please enter some sequence separate by space "&nbsp", or just type "0" or press "Submit" for default array. </p>' +
            '<input type="text" class="value1" size="30" />' +
            '<input type="submit" name="button" id="P3_submit" />' +
            '<p id="resultP3"> </p>';

    var problem4 = '<p> Press the button </p>' +
            '<input type="submit" name="button" id="P4_submit" />' +
            '<p id="resultP4"> </p>';

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
    });

    //Calculation functions
    var result, valueA;
    //Task1
    $(document).on('click', '#P1_submit', function () {
        valueA = $('.value1').val();
        var arr = [];
        var i = 0;
        f();
        function f() {
            i++;
            arr.push(i + " ");
            result = "" + arr;
            $('#resultP1').html("Result: " + result);
            if (i < valueA) {
                setTimeout(f, 300);
            }
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
        var arr = [];
        var i = 0;
        f();
        function f() {
            i++;
            if (i % 3 != 0 && i % 7 != 0) {
                arr.push(i + " ");
                result = "" + arr;
                $('#resultP2').html("Result: " + result);
            }
            if (i < valueA) {
                setTimeout(f, 200);
            }
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
        $('#P3_submit').css({"margin-left": "10px"});
    });

    //Calculation functions
    //Task3
    $(document).on('click', '#P3_submit', function () {
        var min, max, a;
        var valueA = $('.value1').val();
        if (valueA == 0) {
            var defaultValue = [33504, 15963, 94073, 56791, 81681, 4058, 68912, 40887, 60265, 8954, 70585, 84429, 16066, 30210, 51332, 58345, 30871, 3257, 50976, 11018, 32154, 23075, 3477, 11539, 59347, 60773, 53908, 78723, 46588, 7584];
            a = defaultValue.sort();
            console.log(a);
            $('#resultP3').html("Min: " + Math.min.apply(Math, a) + " &nbsp;&nbsp;&nbsp;&nbsp; Max: " + Math.max.apply(Math, a));
        } else {
            console.log("A: " + valueA);
            a = valueA.split(' ');
            $('#resultP3').html("Min: " + Math.min.apply(Math, a) + " &nbsp;&nbsp;&nbsp;&nbsp; Max: " + Math.max.apply(Math, a));
        }
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
    });

    //Calculation functions
    //Task4
    $(document).on('click', '#P4_submit', function () {
        $('#resultP4').append('window');
        getProperties(window);
        $('#resultP4').append('navigator');
        getProperties(navigator);
        $('#resultP4').append('document');
        getProperties(document);

        function getProperties(obj) {
            var min = 0;
            var max = 0;

            for (var property in obj) {
                if (!min) {
                    min = property;
                }
                if (!max) {
                    max = property;
                }

                if (property < min) {
                    min = property;
                }

                if (property > max) {
                    max = property;
                }
            }

            $('#resultP4').append('<p> min: ' + min+'</p>');
            $('#resultP4').append('max: ' + max + '\n\r');
        }
    });
});