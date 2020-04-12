/*
WHILE/FOR COMPARE/CONTRAST

    BOTH while and for statements:
        *Loop through blocks of code when a defined condition is met 

    ONLY WHILE statements:
        *Are used when you want to repeat a block of code indefintely as long as the defined condition is met
    
    ONLY FOR statements:
        *Are used when you know exactly how many times you want to run through a block of code as
        *Have an intialization statement that is not repeated
*/

/*
DO-WHILE OVER WHILE STATEMENT
    A specific example of when it would be more apporpriate to use a do-while statement over a while statement would be a service(s) intialization script where the script runs at least once to intialize the service(s) listed, but
        will continue to run until the service(s) are all successfully intialized. This will start all of the services and THEN check that all services are properly started to determine whether it will need to try again. It would
        be more appropriate to use a do-while loop here because we want to execute the 'start service(s)' code before checking to see if any of the services failed to start.
*/


using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 4

            for (int h = 0; h < 101; h++)
            {
                if ((h % 2) == 0)
                {
                    Console.WriteLine($"{h} is even!");
                }
                else
                {
                    Console.WriteLine($"{h} is odd");
                }
            }

            //Step 5
            Console.WriteLine("Please enter a temperature");

            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp <= 10)
            {
                Console.WriteLine("Polar Bear");
            }

            else if ((temp > 10) && (temp <= 20))
            {
                Console.WriteLine("Penguin");
            }

            else if ((temp > 21) && (temp <= 40))
            {
                Console.WriteLine("Moose");
            }

            else if ((temp > 40) && (temp <= 50))
            {
                Console.WriteLine("Reindeer");
            }

            else if ((temp > 50) && (temp <= 60))
            {
                Console.WriteLine("Deer");
            }

            else if ((temp > 60) && (temp <= 70))
            {
                Console.WriteLine("Turtle");
            }

            else if ((temp > 70) && (temp <= 80))
            {
                Console.WriteLine("Lion");
            }

            else if ((temp > 80) && (temp <= 90))
            {
                Console.WriteLine("Fish");
            }

            else
            {
                Console.WriteLine("Bug");
            }

            //Step 6
            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++; //There was no increment here causing an infinte loop
            }

            //Step 7
            for (int g = 0; g < 101; g++)
            {   Console.WriteLine(g);
                Console.WriteLine("********");  //While FOR loops do not need brackets for a single statements, brackets were added as there were two statements and as best practice to make the code easier to read
            }


        }
    }
}
