using System;

//Step 1
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2
            /*
             A one-dimensional array p contains four elements. The array access expressions to access
                each of the elements in p are p[0], p[1], p[2] and p[3]. 
            */

            //Step 3
            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine($"{i+1} {months[i]}");
            }

            //Step 4
            string[] seasons = {"Spring", "Summer", "Fall", "Winter"};

            foreach (string i in seasons)
            {
                Console.WriteLine(i);
            }

            //Step 5
            int[] array = new int[1000];

            Random random = new Random();

            int randomNumber;

            for (var i = 0; i < 1000; ++i)
            {
                randomNumber = random.Next(0, 100);
                array[i] = randomNumber;
            }

            foreach (int value in array)
            {
                Console.WriteLine(value);
            }

            //Step 6
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "GingerRayle", "Iona Ford" };

            int g = 0;

            while (g < names.Length)
            {
                Console.WriteLine(names[g]); //Replaced '0' with 'g'
                g++; //Added increment
            }
        }
    }
}
