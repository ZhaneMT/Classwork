// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;

namespace FirstProgram;

// This program will ask for three numbers
//  add them together and display the total

// Programming Solution - Human thinking
// Identify the detailed steps

// Ask for the numbers one at a time 
// Write-down each number as its given.
// Add the numbers together create a sum/total 
// Tell the requester the total (display)
//
// Now that we have the steps in our solution 
// Identify any data you need for the steps
//
// 1. I need a place to write down each number. - A variable in a program.
// 2. We need a place to hold the sum/total. - A variable in a program.
// 3. A way to ask for the numbers one at a time. - A method in a program.(object.method())
// 4. A way to receive the numbers. - A method in a program.(object.method())
// 5. A way to report the sum/total. - A method in a program.(object.method())
//
// Place the steps in the order and provide more detail if necessary.
//
// 1. Ask for the numbers one at a time. 
//      a.Tell whoever is giving us the numbers, to give me the first number. 
//      b. Receive the first number from sender. 
//      c. Write down the first number.
//      d.Tell whoever is giving us the numbers, to give me the second number. 
//      e. Receive the second number from sender. 
//      f. Write down the second number.
//      g.Tell whoever is giving us the numbers, to give me the third number. 
//      h. Receive the third number from sender. 
//      i. Write down the third number.
//
// 2. Add the numbers together create a sum/total 
//      a. Add the first number to a sum/total
//      a. Add the second number to a sum/total
//      a. Add the third number to a sum/total
//
// 3. Tell the requester the total (display)

class Program
{
    static void Main(string[] args)
    {
        /*************************************************************************
         *Define my data at the type of the program.
         *
         * Data may be defined anywhere before its used, it easier to
         * find at the top of the program
         *
         * To define a variable: data-type Varname = initial value
         *
         * Commonly used data types in C#:
         *
         *      int     - Numberic data that is a whole number between +/- 2 billion.
         *      long    - A whole number greater than +/- 2 billion.
         *      double  - A numeric value with decimal places.
         *      char    - A single alphanumeric character.
         *      string  - A series of alphanumeric characters (words, sentences, etc).
         *      bool    - True or False value for conditions.
         *
         *      examples:   10 - int (or long)
         *                  1.0 - double
         *                  'a' - char (note is enclosed in ' ')
         *                 "some words" - string(note is enclosed in " ")
         *
         *  Variable names C# are usually spelled in camelCase; Use _ to seperate words 
         * (camelCase means the first letter is in lowercase all other words
         *            start with upper case letter)
         * It's always good to initialize your variables when defining them 
         *******************************************************************************/
        
        //  Define the variables to hold the numbers we need to add
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        // Define a variable to hold the sum of the numbers

        int sum = 0;
        Console.WriteLine("----Starting Program----");
        
        // Ask for the numbers one at time using the C# Console object
        //  which represents the keyboard and screen
        // Console.Readline() returns a string - cannot store in an int
        
        Console.WriteLine("Please enter the first number: "); // Asking for the number
     //   Console.ReadLine();                              // Get a line from the keyboard
        string aLine;       //String to hold the line of input from keyboard
        aLine = Console.ReadLine();
        
        // We need an int value to store our numbers
       // Console.ReadLine() only returns a string.
       // So we need to convert the string from Console.ReadLine() to an int.
       // int.Parse(string) will convert a string to an int
       
       number1 = int.Parse(aLine);
       
       // Verify that I got the data I expected
       // Display some words and the value I received.
       // "string" + something is called concatenation (it sticks them together)
       
       Console.WriteLine("You entered: " + number1);
       
        Console.WriteLine("-----Ending Program----");
    }
}