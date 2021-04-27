using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Types
{
    [TestClass]
    public class TypeEamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            // -- Whole Number
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;  // Int 16
            int wholeNumber = 32;         // Int 32
            long largeWholeNumber = 64;   // Int 64


            float floatExmple = 1.234567f;
            double doubleExample = 1.234567d;
            decimal decimalExample = 1.234567m;


            char letter = 'j';

            // -- Operators

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prop = numOne * numTwo;
            Console.WriteLine(prop);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");      

        }


        [TestMethod]
        public void ReferenceTypes()
        {
            //strings
            string stringExample = "This is a string";
            string name = "Joshua";

            string declared;
            declared = "Now it's Initialized";


            //formatting strings
            string concatenate = stringExample + " " + name;
            string interpolate = $"{name}. Here is the string: {stringExample}.";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

             



        }
    }
}
