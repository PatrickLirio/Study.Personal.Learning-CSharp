using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesAndDatatypes
{
    /*
      * Learning Variables and Datatypes Part 2
      * 
      */
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Part 2!");

            #region --- Local variables ---

            /*
             *Types of Declaring Variables
             *
             *Variables are containers for storing data values.
             *Local variables are variables declared in a method inside a class.
             */

            // Explicitly declaring variable type
            int explicitNumber = 100;
            Console.WriteLine($"Explicitly Declared Number: {explicitNumber}");
            // Implicitly declaring variable type using 'var'
            var implicitNumber = 200;
            Console.WriteLine($"Implicitly Declared Number: {implicitNumber}");
            Console.WriteLine(
                $"Type of explicitNumber: {explicitNumber.GetType()}, Type of implicitNumber: {implicitNumber.GetType()}"
            );
            // Using 'dynamic' type
            /*Note!
             * Runtime = the time when the program is running
             * Design Time = the time when the program is being written
             * Design time type checking is done by the compiler
             * Runtime type checking is done during program execution
             * 
             * Implicit and Explicit types are checked at Design Time
             * Dynamic type is checked at Runtime
             */
            Console.WriteLine(
                "Using 'dynamic' type allows variable to change type at runtime."
            );
            dynamic dynamicVariable = 300;
            Console.WriteLine(
                $"Dynamic Variable initially as int: {dynamicVariable}, Type: {dynamicVariable.GetType()}"
            );

            #endregion

            Console.WriteLine("=======");

            // Let us access the value of the public and private variable in the ScopeVariablesExample
            var accessingPublicAndPrivateClass = new ScopeVariablesExample(); // storing the values of ScopeVariableExample to a new variable by making it as an instance
            Console.WriteLine(accessingPublicAndPrivateClass.samplePublitInt);
            accessingPublicAndPrivateClass.samplePublitInt = 821;
            Console.WriteLine(accessingPublicAndPrivateClass.samplePublitInt);

            Console.WriteLine("*************");
            Console.WriteLine(ScopeVariablesExample.sampleStaticOrClassVariableInt);
            ScopeVariablesExample.sampleStaticOrClassVariableInt++;
            Console.WriteLine(ScopeVariablesExample.sampleStaticOrClassVariableInt);



        }

        

    }
    /*
     * Scope Variables, Field Variables, Class Variable and Instance Variable
     *  Keywords (Static,Readonly,Const)
     */
    public class ScopeVariablesExample
    {
        #region ---- Class Variable and Instance Variable ----

        public static int sampleStaticOrClassVariableInt = 30;//Class Variable  

        public int samplePublitInt = 460;
        private int samplePrivateInt = 780;

        /*Note!
         * -The public variable is also called "instance variable" because it can only
         * be access if we created an instance of the class before we can access the public variable.
         * 
         * - The Private variable is also like a field, it can only be access within the class.
         * 
         * - In class variable you don't need to create an instance (like public) just to access it.
         */

        #endregion


        #region --- Fields ---
        int sampleField1 = 40; // fields or global variable inside a class
        static int sampleStaticInt = 35; // static variable inside a class
        readonly int sampleReadOnlyInt; // readonly variable inside a class
        readonly long sampleReadOnlyInt2 = 40; // readonly variable inside a class
        const int sampleIntNaConst = 12; // const variable inside a class
        const double pi = 3.14; // const variable inside a class

        /*Note!
         * Only the CONST variable are the only variable that can't be modify even in a constructor.
         * Fields can only be access within the class.
         */
        #endregion
        public void SampleMethod1()
        {
            int sampleLocalInt1 = 10;
            var sampleLocalInt2 = 321;
            Console.WriteLine(sampleField1);  
            /*Note!
             * You CANNOT access the variable from SampleMethod2 here.
             * You CAN access the field variables here ex. sampleFiled1
             */
        }
        public void SampleMethod2()
        {
            int sample1Int = 1;
            Console.WriteLine(sampleField1);
            /*Note!
             * You CANNOT access the variable from SampleMethod1 here.
             * You CAN access the field variables here ex. sampleFiled1
             */
        }

        public static void SampleStaticMethod()
        {
            sampleStaticInt = 5;

            /*Note!
             * You CANNOT access static variables in this static method.
             * 
             */
        }

        public ScopeVariablesExample()
        {
            sampleReadOnlyInt = 2;
            sampleReadOnlyInt2 = 400;

            /*Note!
             * The readonly variables can only modify their values ones.
             * The readonly variables can only be called in a constructor of a class.
             */
        }
    }

}
