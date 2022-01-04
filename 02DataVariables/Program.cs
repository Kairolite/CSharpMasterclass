using System;

namespace _02DataVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // INT, FLOAT, AND DOUBLE

            // declaring multiple variables at once
            int num3, num4, num5;

            //declaring a variable
            int num1;

            // assigning a value to a variable
            num1 = 13;

            // declaring and initializing a variable in one go
            int num2 = 23;

            //long myLongNum = 130135135985398;
            //int myLongInt = 130135135985398; too big to fit into integer

            num2 = 100;
            int sum = num1 + num2;

            // using concatenation
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            //int diDivInt = d1 / num1; be careful of the data type certainty
            Console.WriteLine("d1/num1 is " + dIDiv);

            Console.ReadLine();

            // STRINGS

            string myname = "Chris";
            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCaseMessage);

            Console.ReadLine();

            // CONSOLE METHODS

            Console.WriteLine("Enter a string and press enter :");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.WriteLine("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello Chris");
            Console.WriteLine("C# is amazing!");
            Console.ReadKey();

            // CONVERSION
            Console.Clear();

            // implicit conversion
            int num = 123456789;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            // explicit conversion
            double myDouble = 13.37;
            int myInt;
            // cast double to int
            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.ReadKey();

            // type conversion
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);
            Console.ReadKey();

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);
            Console.ReadKey();

            // PARSING STRING TO INT
            Console.Clear();
            string myFistString = "15";
            string mySecondString = "13";
            int nume1 = Int32.Parse(myFistString);
            int nume2 = Int32.Parse(mySecondString);
            int resultInt = nume1 + nume2;
            string myResult = myFistString + mySecondString;
            Console.WriteLine(myResult);
            Console.WriteLine(resultInt);
            Console.ReadLine();
        }
    }
}
