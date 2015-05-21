$(document).ready(function (){
    
    //DOM durvoto na html faila
    var mainHTML = '<div id="nav">'+
                   '<ul>'+
                   '<li id="task1"> Odd or Even </li>'+
                   '<li id="task2"> Divided by 7 and 5 </li>'+
                   '<li id="task3"> Rectangle area </li>'+
                   '<li id="task4"> Third digit </li>'+
                   '<li id="task5"> Third bit </li>'+
                   '<li id="task6"> Point in Circle </li>'+
                   '<li id="task7"> Is prime </li>'+
                   '<li id="task8"> Trapezoid area </li>'+
                   '<li id="task9"> Point in Circle and outside Rectangle </li>'+
                   '</ul>'+
                   '</div>'+
                   '<div id="tasks">'+
                   '</div>';
    
    //Vizualizira HTML-a
    $('#main-container-HomeWorkJS').html(mainHTML);
    
    //Style of the DOM  
    $('#nav').css({"background-color":"grey", "width":"160px" , "float":"left"});
    $('#nav > ul > li').css({"padding":"5px", "color":"white",
      "overflow":"hidden", "margin-left":"-40px", "width":"150px",
      "border-bottom":"2px solid gold"});
    
    $('#tasks').css({"border":"1px solid black", "border-radius":"10px",
        "margin-left":"170px", "padding-left":"20px", "width": "500px"});
      
    
    //Hover na Li-tata
    $("#nav > ul > li").mouseenter(function() {
        $(this).css({"color":"#F00"});
        }).mouseleave(function() {
             $(this).css({"color":"white"});
        });
        
    
    
    var problem1 = '<p> Enter integer to chek if is odd or even </p>'+
                   '<input type="text" name="inputP1" id="Odd_Even" />'+
                   '<input type="submit" name="button" id="P1_submit" />'+
                   '<p id="resultP1"> </p>';
           
    var problem2 = '<p> Please input integer to chek if it is divided by 5 and 7 in the same time</p>'+
                   '<input type="text" name="inputP2" id="Divided_Input" />'+
                   '<input type="submit" name="button" id="P2_submit" />'+
                   '<p id="resultP2"> </p>';
    
    var problem3 = '<p> Please input width and height to calculate rectangle`s area</p>'+
                   'Width: <input type="text" name="inputP3_width" id="width_Input" size="3" />'+
                   'Height: <input type="text" name="inputP3_height" id="height_Input" size="3" />'+
                   '<input type="submit" name="button" id="P3_submit" />'+
                   '<p id="resultP3"> </p>';
          
    var problem4 = '<p> Please input integer checks its third digit (right-to-left) is 7</p>'+
                   '<input type="text" name="inputP2" id="third_digit_Input" />'+
                   '<input type="submit" name="button" id="P4_submit" />'+
                   '<p id="resultP4"> </p>';
           
    var problem5 = '<p> Please input integer to check bit#3</p>'+
                   '<input type="text" name="inputP5" id="bit_Input" />'+
                   '<input type="submit" name="button" id="P5_submit" />'+
                   '<p id="resultP5"> </p>';
     
    var problem6 = '<p> Please enter the point (x,y), to check if they are within a circle K(O, 5).</p>'+
                   'X: <input type="text"  id="x_Input" size="3" />'+
                   'Y: <input type="text"  id="y_Input" size="3" />'+
                   '<input type="submit" id="P6_submit" />'+
                   '<p id="resultP6"> </p>';
           
    var problem7 = '<p> Please enter to checks if by given positive integer number n (n ≤ 100) is prime.</p>'+
                   '<input type="text"  id="num_Input" size="5" />'+
                   '<input type="submit" id="P7_submit" />'+
                   '<p id="resultP7"> </p>';
           
    var problem8 = '<p> Please enter to calculates trapezoid area by given sides a and b and height h.</p>'+
                   'A: <input type="text"  id="a_Input" size="4" />'+
                   'B: <input type="text"  id="b_Input" size="4" />'+
                   'H: <input type="text"  id="h_Input" size="4" />'+
                   '<input type="submit" id="P8_submit" />'+
                   '<p id="resultP8"> </p>';
            
    var problem9 = '<p> Please enter to checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).</p>'+
                   'X: <input type="text"  id="coordX_Input" size="4" />'+
                   'Y: <input type="text"  id="coordY_Input" size="4" />'+
                   '<input type="submit" id="P9_submit" />'+
                   '<p id="resultP9"> </p>';
               
       // OnClick on the navigation buttons
       //Task1
       $(document).on('click','#task1', function(){ 
           $('#tasks').html(problem1);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task1').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P1_submit').css({"margin-left":"10px"});
       });
       
       //Task2
       $(document).on('click','#task2', function(){ 
           $('#tasks').html(problem2);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task2').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P2_submit').css({"margin-left":"10px"});
       });

       //Task3
       $(document).on('click','#task3', function(){ 
           $('#tasks').html(problem3);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task3').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#width_Input').css({"margin-right":"10px"});
        $('#P3_submit').css({"margin-left":"10px"});
       });
       
       //Task4
       $(document).on('click','#task4', function(){ 
           $('#tasks').html(problem4);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task4').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P4_submit').css({"margin-left":"10px"});
       });
       
       //Task5
       $(document).on('click','#task5', function(){ 
           $('#tasks').html(problem5);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task5').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P5_submit').css({"margin-left":"10px"});
       });
       
       //Task6
       $(document).on('click','#task6', function(){ 
           $('#tasks').html(problem6);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task6').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P6_submit').css({"margin-left":"10px"});
        $('#x_Input').css({"margin-right":"10px"});
       });
       
       //Task7
       $(document).on('click','#task7', function(){ 
           $('#tasks').html(problem7);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task7').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P7_submit').css({"margin-left":"10px"});
       });
       
       //Task8
       $(document).on('click','#task8', function(){ 
           $('#tasks').html(problem8);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task8').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P8_submit').css({"margin-left":"10px"});
        $('#a_Input').css({"margin-right":"10px"});
        $('#b_Input').css({"margin-right":"10px"});       
        
       });
       
       //Task9
       $(document).on('click','#task9', function(){ 
           $('#tasks').html(problem9);
           $("#nav > ul > li").css({"color":"white"}).mouseleave(function() {
             $(this).css({"color":"white"});
         });
           $('#task9').css("color","green").mouseleave(function() {
             $(this).css({"color":"green"});
        });
        $('#P9_submit').css({"margin-left":"10px"});
        $('#coordX_Input').css({"margin-right":"20px"});
       });
        
        //Calculation functions
        var result, valueA, valueB, valueC;
        //Task1
        $('#main-container-HomeWorkJS').on('click','#P1_submit', function(){
            valueA = $('#Odd_Even').val();
            
            if(valueA%2 == 0) {result = false;}
            else {result = true; }
            $('#resultP1').html("The value is Odd: " + result );
        });
        
        //Task2
        $('#main-container-HomeWorkJS').on('click','#P2_submit', function(){
            valueA = $('#Divided_Input').val();
            if((valueA%5 == 0) && (valueA%7 == 0)) {result = true;}
            else {result = false; }
            $('#resultP2').html("The value is divided by 5 and 7: " + result );
        });
        
        //Task3
        $('#main-container-HomeWorkJS').on('click','#P3_submit', function(){
            valueA = $('#width_Input').val();
            valueB = $('#height_Input').val();
            result = valueA * valueB;
            $('#resultP3').html("Area: " + result );
        });
        
        //Task4
        $('#main-container-HomeWorkJS').on('click','#P4_submit', function(){
            valueA = $('#third_digit_Input').val();
            valueA = valueA/100;
            result = valueA%10;
            if(parseInt(result, 10) == 7) {result = true;}
            else {result = false;}
            $('#resultP4').html("Third digit is 7 : " + result);
        });
        
        //Task5
        $('#main-container-HomeWorkJS').on('click','#P5_submit', function(){
            valueA = $('#bit_Input').val();
            //Position 3
            result = (valueA >> 3) & 1;
            
            $('#resultP5').html("bit #3 : " + result);
        });

        //Task6
        $('#main-container-HomeWorkJS').on('click','#P6_submit', function(){
            var x = $('#x_Input').val();
            var y = $('#y_Input').val();
            result = (x - 0) * (x - 0) + (y - 0) * (y - 0) < 5 * 5; 
            $('#resultP6').html("Inside : " + result);
        });
        
        //Task7
        $('#main-container-HomeWorkJS').on('click','#P7_submit', function(){
            valueA = $('#num_Input').val();
            result = isPrime(valueA);
            $('#resultP7').html("Is prime : " + result);
        });
        
        function isPrime(num) {
            if (isNaN(num) || !isFinite(num) || num % 1 || num < 2) {
                return false;
            }

            var m = Math.sqrt(num);
            for (var i = 2; i <= m; i++) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        }
        
        //Task8
        $('#main-container-HomeWorkJS').on('click','#P8_submit', function(){
            valueA = $('#a_Input').val();
            valueB = $('#b_Input').val();
            valueC = $('#h_Input').val();
            
            result =((parseFloat(valueA) + parseFloat(valueB)) /2 ) * parseFloat(valueC);
            $('#resultP8').html("Area : " + result );
        });
        
        //Task9
        $('#main-container-HomeWorkJS').on('click','#P9_submit', function(){
            var x = $('#coordX_Input').val();
            var y = $('#coordY_Input').val();

            var a = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3;
            var b = (x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2), result = "NO";
            
             if (a && !b) {
                result = "YES";
            }
            $('#resultP9').html("inside K & outside of R : " + result);
        });

        
        
});

/*Problem 1. Odd or Even

Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
Problem 2. Divisible by 7 and 5

Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	true
5	false
7	false
35	true
140	true


Problem 3. Rectangle area

Write an expression that calculates rectangle’s area by given width and height.
Examples:

width	height	area
3	4	12
2.5	3	7.5
5	5	25



Problem 4. Third digit

Write an expression that checks for given integer if its third digit (right-to-left) is 7.
Examples:

n	Third digit 7?
5	false
701	true
1732	true
9703	true
877	false
777877	false
9999799	true


Problem 5. Third bit

Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
Examples:

n	binary representation	bit #3
5	00000000 00000101	0
8	00000000 00001000	1
0	00000000 00000000	0
15	00000000 00001111	1
5343	00010100 11011111	1
62241	11110011 00100001	0



Problem 6. Point in Circle

Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
Examples:

x	y	inside
0	1	true
-5	0	true
-4	5	false
1.5	-3	true
-4	-3.5	false
100	-30	false
0	0	true
0.2	-0.8	true
0.9	-4.93	false
2	2.655	true


Problem 7. Is prime

Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
37	true
97	true
51	false
-3	false
0	false

Problem 8. Trapezoid area

Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:

a	b	h	area
5	7	12	72
2	1	33	49.5
8.5	4.3	2.7	17.28
100	200	300	45000
0.222	0.333	0.555	0.1540125



Problem 9. Point in Circle and outside Rectangle

Write an expression that checks for given point P(x, y) if it is within the 
circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:

x	y	inside K & outside of R
1	2	yes
2.5	2	no
0	1	no
2.5	1	no
2	0	no
4	0	no
2.5	1.5	no
2	1.5	yes
1	2.5	yes
-100	-100	no*/