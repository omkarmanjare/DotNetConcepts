using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{
    //when we pass the argument of type int, double, decimal, etc (basic value types), we do not pass the actual value but its copy.
    //This means that our original values are not changed inside the methods, because we pass a new copy of the original value.
    //. If we want to change the original values inside our methods, we can do that by using ref and out keywords 
    
    public class RefOut
    {
        //If we want to change an existing value of a variable inside a method, we are going to use the ref keyword.
        // need to initilize before passed 
        //The passing of value through ref parameter is useful when the called method also need to change the value of passed parameter.
        public static void ChangeRef(ref int numberRef)
        {
            numberRef = 25;
            Console.WriteLine($"Inside the ChangeRef method the numberRef is {numberRef}");
        }

        //if we want to assign a completely new value to the variable inside a method, then we use the out keyword.
        //you dont have to write return keyowrd and return here
        //with the out keyword we can use unassigned variables.
        //Useful when a method returns multiple values.
        //not necessary to initilize
        public static void ChangeOut(out int numberOut)
        {
            numberOut = 60;
            Console.WriteLine($"Inside the ChangeOut method the numberOut is {numberOut}"); 
        }

        public static void  Demo()
        {
            int numberRef = 15;

            Console.WriteLine($"Before calling the ChangeRef method the numberRef is {numberRef}");
            ChangeRef(ref numberRef);
            Console.WriteLine($"After calling the ChangeRef method the numberRef is {numberRef}");
            Console.WriteLine();
            int numberOut;
            Console.WriteLine("Before calling the ChangeOut method the numberOut is unassigned");
            ChangeOut(out numberOut);
            Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");
            Console.ReadKey();
        }
    }
}
