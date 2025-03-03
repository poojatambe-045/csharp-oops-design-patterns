using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPS_Concept.DRY_Principle
{
    public class DryDemo
    {
        // DRY code
        public static string greetUser(string userName)
        {
            return "Hello " + userName + "!";
        }
        // DRY code
        public static void SquareNumber(int num)
        {
             Console.WriteLine(num * num);
        }

        public static void Main()
        {
            // Repetitive code
            string firstGreet = "Hello First User!";
            Console.WriteLine(firstGreet);

            string secondGreet = "Hello Second User!";
            Console.WriteLine(secondGreet);

            // DRY code
            Console.WriteLine(greetUser("First User"));
            Console.WriteLine(greetUser("Second User"));



            // Repeated code
            int square1 = 3 * 3;
            Console.WriteLine(square1);
            int square2 = 4 * 4;
            Console.WriteLine(square2);
            int square3 = 5 * 5;
            Console.WriteLine(square3);


            SquareNumber(3);
            SquareNumber(4);
            SquareNumber(5);
        }
    }
}


//Hello First User!
//Hello Second User!

//Hello First User!
//Hello Second User!

//9
//16
//25

//9
//16
//25