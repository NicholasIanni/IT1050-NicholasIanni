using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
         //Just a heads up, the Lab2 instructions were not very clear and I suspect some mistakes in your typing... In some of the steps I made substitutions/interpretation (with comments) to make the code how I thought you intended it. If this was an excerise of precisely following directions, I have failed.     
           
            //Step 1 
               
                string firstName = "Nick";  //(unsure if you meant this as a two-part thing or a single variable defined as "hello, Nick!")
                Console.WriteLine($"hello, {firstName} !");

            //Step 2
                //firstName is already defined.
                string lastName = "Ianni";
                string major = "Electrical Engineering";

                Console.WriteLine($"{firstName} {lastName}'s major is {major}.");

            //Step 3
                int a = 3;
                int b = 20;
                string sumString = "The Sum is";

                // Here just the integers 'a' and 'b' are being added together with the sum operator where the actual sum will be given.
                Console.WriteLine(a+b);

                // Here the string 'sumString' is being combined with the concatenation operator as a single string with the integers 'a' and 'b' , so the output is given as a string since the variables weren't correctly interpolated.
                Console.WriteLine(sumString + a + b);   //substituted 'sum' with sumString to function properly

            //Step 4
                int number1 = 3;
                int number2 = 6;
                int number3 = 9;

                Console.WriteLine($"The average of {number1}, {number2}, and {number3} is equal to {(number1 + number2 + number3) / 3}.");

            //Step 5
                int pi = 355/113;
                double piDouble = 355d / 113d;
                decimal decimalPi = 355m / 113m;    //substituted second '355m' with '133m' to get pi

                //Because this variable was defined as an int, it does not allow for the decimal calculation to be stored and is left as the integer 3 (with no remainder because the modulus operator is not used).
                Console.WriteLine("int pi: " + pi);

                //Becuase this variable was defined as a double, the calculation is given in decimal form with 15 decimal digits.
                Console.WriteLine("double pi: " + piDouble);

                //Because this variable was defined as a decimal, the calculation is given in decimal form with 29 decimal dogits.
                Console.WriteLine("decimal pi: " + decimalPi);



        }
    }
}
