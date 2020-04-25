//Step 2

        /* public double getArea(double height, double width)
            {
                return height * width;
            }
        */
    /*
     a.Scope - "public" - This allows the method to be available outside of the class. This could also be private which would not make it available outside of the class. In general, each nested set of curly braces is a deeper scope.

     b.Static vs.Non-Static - "Non-Static" - Static methods must be specified as static in their declaration. Statics cannot be instantiated. Static methods can be called directly, while non-static methods must have an instance created for it to be called.

     c.Return Type - "Double" - This is what the method is supposed to return. This could also be any primitive data type (ex. int) or void if the method is not supposed to return a value.

     d.Method Name (Identifier) - "getArea" - This is the term that is used to call and use the method. This could also be any other name.

     e.Parameters - "height, width" - These are the input variables for the method. They are assigned and input using in the parentheses after the method declaration and call respectivly. Parameters are seperated by commas.

     f.Method Body - "return height * width" - This is what the method is doing/the code it is executing with the parameters you are passing it.
    */

//Step 3
    //When using a framework it is important to include that framework in the header of your code (ex. using system) so that it is available for you to call from. When using a user-created method it is important to evaluate whether it should be declared as static or non-static based on how it is used. 

//Step 4
    //A static method cannot be instantiated and can be called directly, while non-static methods must have an instance created for them to be called.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            // To do: uncomment the following lines of code to call the methods
            myDog.bark();
            myDog.doTrick("Fetch");

            Console.ReadLine();
        }
    }
}
