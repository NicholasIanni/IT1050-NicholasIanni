/*
 IF THEN COMPARE/CONTRAST

Both if, then statements and while loops:
 *Execute the contained code only once the defined condition is met

Only if, then statements:
 *Execute the contained code only ONE TIME once the defined condition is met

Only while loops:
 *Execute the contained code REPEATEDLY WHILE the defined condition is met

*/


using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
         //If, then
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
                }

         //If, else
            bool isTrue = true;

            Console.WriteLine("True or False?");

            isTrue = Convert.ToBoolean(Console.ReadLine());

            if (isTrue == true)
            
                Console.WriteLine("It is True!");
            
            else
            
                Console.WriteLine("It is False!");
            


         //While loop #1
            int number = 0;
            while (number < 11)
            {
                Console.WriteLine(number);
                number++;
            }

         //While loop #2
            int number2 = 60;
            while (number2 > 15)
            {
                Console.WriteLine(number2);
                number2 = number2 - 5;

            }

         //While loop #3
            int number3 = 10;
            while (number3 < 22)
            {
                Console.WriteLine(number3);
                number3 = number3 + 2;
            }

        }
    }
}
