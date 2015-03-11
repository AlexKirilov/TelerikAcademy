using System;


namespace The_Biggest_of_3_Numbers
{
    class TheBiggestOf3
    {
        static void Main()
        {
            Console.WriteLine("Enter three digits");
            double a, b, c;
            Console.Write("\na = ");
            bool isADouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("\nb = ");
            bool isBDouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("\nc = ");
            bool isCDouble = double.TryParse(Console.ReadLine(), out c);
            //Checking for valid entry
            if (isADouble && isBDouble && isCDouble)
            {
                double max = Math.Max(a,b);
                if(max > c) {      Console.WriteLine("The biggest from three numbers is {0} ", max ) ;  }
                else  {     Console.WriteLine("The biggest from three numbers is {0} ", c ) ;  }
            }
            else { Console.WriteLine("Bad input, try again"); }
            Main(); // Recursive function
        }
    }
}
