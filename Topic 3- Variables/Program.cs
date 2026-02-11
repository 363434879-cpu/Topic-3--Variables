using System;

namespace Topic_3__Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naika

            // Declare string variables (text)
            string firstName, lastName, eyeColor, hairColor, teethColor;

            // Declare integer variables (whole numbers)
            int age, height, weight;

            // Assign values to the variables
            firstName = "John";
            lastName = "Smith";
            age = 35;
            height = 74;
            weight = 180;
            eyeColor = "Blue";
            hairColor = "Brown";
            teethColor = "White";

            // Print a sentence using first and last name
            Console.WriteLine("Let's talk about " + firstName + " " + lastName + ".");

            // Convert inches to centimeters (1 inch = 2.54 cm)
            Console.WriteLine("He's " + height + " inches (or " + (height * 2.54) + " cm) tall.");

            // Convert pounds to kilograms
            Console.WriteLine("He's " + weight + " pounds (or " + (weight / 2.2) + " kg) heavy.");

            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyeColor + " eyes and " + hairColor + " hair.");
            Console.WriteLine("His teeth are usually " + teethColor + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                + " I get " + (age + height + weight) + ".");

            // string firstName; declares a variable called firstName that will store a sequence of characters, called a ‘string’
            //  int age; declares a variable called age that will store integer values
            //  double price;  declares a variable called price that will store decimal values
            // bool done;  declares a variable called done that can either store true or false

            Console.WriteLine();
            Console.WriteLine("Press ENTER to see examples.");
            Console.ReadLine();
            Console.Clear();

            //Example 1
            //Removing the double quotes from Jonathan = ERROR
            string name = "Jonathan";
            Console.WriteLine(name);
            name = "Jon";
            Console.WriteLine(name);

            //Example 2
            //Adding double quotes to 15 = ERROR
            //Adding statement myNumber = 20; will change the value of myNumber to 20
            int myNumber = 15;
            myNumber = 20;
            Console.WriteLine(myNumber);

            //Example 3
            // Declare a variable named personHeight
            // "double" means it can store decimal numbers (not just whole numbers)
            double personHeight = 1.62;
            // Print the value stored inside personHeight to the screen
            // Console.WriteLine displays whatever is inside the brackets
            // We use "double" instead of "int" because 1.62 has a decimal.
            // An int can only store whole numbers (like 1, 2, 3).
            // A double can store decimal numbers (like 1.62, 3.14, 2.5).
            Console.WriteLine(personHeight);

            //Questions:

            // 1. What is the difference between an ‘int’ and a ‘double’ datatype?
            // An int stores whole numbers only (no decimals), like 5, 10, or -3.
            // A double stores decimal numbers, like 3.14, 1.62, or 9.5.
            // Example of int: int age = 15;  // Age is usually a whole number
            // Example of double: double height = 1.62;  // Height can have decimals


            // 2. Can the computer solve a mathematical expression that uses both doubles and integers?
            // Yes, it can.
            // If a math expression uses both int and double, the int is automatically converted to a double.
            // The final answer will be a double (decimal result).


            // 3. What happens if you perform a mathematical operation on all integers that has a decimal answer?
            // If you divide two integers, the decimal part is removed (it gets truncated, not rounded).
            // Example:
            int personage = 15;
            Console.WriteLine(personage / 2);
            // This prints 7, not 7.5, because both numbers are integers.


            // How could you make the above print the exact answer with a decimal?
            // Make one of the numbers a double.
            Console.WriteLine(age / 2.0);   // Prints 7.5
                                            // OR
            Console.WriteLine((double)age / 2);  // Also prints 7.5


            // 4. What happens to the previous value after assigning a new value?
            // The old value is replaced (overwritten) and is lost.
            // The variable now stores only the new value.

            //Constants:
            // If you try to assign a different value to Tax later in your program, you will get an error.
            // This is because "const" means the value is constant and cannot be changed after it is declared.
            // Constants are read-only, so once Tax is set to 0.13, it stays 0.13 for the entire program.
            const double Tax = 0.13;
            double item1Tax, item1Price = 5.99;
            item1Tax = item1Price * Tax;
            Console.WriteLine("The tax on your item is " + item1Tax.ToString("C"));


        }
    }
}
