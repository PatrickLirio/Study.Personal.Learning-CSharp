using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesAndDatatypes
{
    /*
      * Learning Variables and Datatypes
      * 
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * We are going to apply already the 4 Programming Principles
             * - KISS (Keep It Simple Stupid)
             * - DAMP (Descriptive And Meaningful Phrases)
             * - WET (Write Everything Twice)
             * - DRY (Don't Repeat Yourself)
             * 
             */

            // KISS Principle
            Console.WriteLine("KISS PRINCIPLE");
            /* No Kiss */
            int sampleNumber = 89;
            string stringNumbers = ConvertIntoString(sampleNumber);
            Console.WriteLine(stringNumbers);
            Console.WriteLine(stringNumbers.GetType());

            string ConvertIntoString(int input)
            {
                return input.ToString();

            }

            /* With kiss */
            int sampleNumberWithKiss = 90;
            string stringNumberTwo = sampleNumberWithKiss.ToString();
            Console.WriteLine(stringNumberTwo);
            Console.WriteLine(stringNumberTwo.GetType());

            Console.WriteLine("============");

            // DAMP Principle
            Console.WriteLine("DAMP Principle");
            /* Violating DAMP */
            string a = "Patrick";
            Console.WriteLine($"Hi! My Name is : {a}");

            /* Following Damp */
            string name = "Patrick";
            Console.WriteLine($"Hi! I am {name}");

            Console.WriteLine("============");

            //WET and DRY Principle
            Console.WriteLine("WET");
            /* Violating WET*/
            int num1 = 9;
            int num2 = 10;
            int num3 = 11;
            int num4 = 12;

            Console.WriteLine($"num1 + num2 = {num1 + num2}");
            Console.WriteLine($"num2 + num3 = {num2 + num3}");
            Console.WriteLine($"num3 + num4 = {num3 + num4}");
            /*
             * NOTE!!!
             * if you are doing it more than twice it is wrong!
             * 
             */

            /* Following DRY */
            Console.WriteLine("DRY");
            AddTwoNumbers("num1 + num2", num1, num2);
            AddTwoNumbers("num2 + num3", num2, num3);
            AddTwoNumbers("num3 + num4", num3, num4);

            void AddTwoNumbers(string text, int input1, int input2)
            {
                Console.WriteLine($"{text} = {input1 + input2}");
            }

            /*
             * Datatypes categories
             * - Value Type = store its contents in the memory allocated on the stack
             * - Reference Type = stored on the heap and passed by creating a reference.
             * - Pointer Type = 
             * 
             */

            /*
             * Value type examples
             * *bool
             * *byte
             * *char
             * *decimal
             * *decimal
             * *double
             * *float
             * *int
             * *long
             * *sbyte
             * *short
             * *uint
             * *ulong
             * *ushort
             */

            /*
             * Reference type examples
             * *object
             * *string
             * *class
             * *dynamic
             * *interface
             * *delegate
             * *record
             */

            //Declaration of Data type

            /* Multiple variable in one Line */
            int number1, number2, number3;

            /* Single Variable per Line */
            int s1 = 1;//initializing default value
            int s2;
            int s3;




        }
    }
    }
