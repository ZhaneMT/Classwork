// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----Start of Program----");

        //Ask the user for 3 numbers, one at a time - A loop
        //Produce a sum

        //1. Do this 3 times
        //      Ask user to enter a numebr
        //      Get the number from user
        //      Add the number to a sum
        //
        //2. Display the sum of the numbers

        //Data we need:
        //
        // 1. a place to hold the number entered by the user.
        // 2. a place to hold the sum of the numbers.

        // Define a place to hold the number entered by the user.

        int firstEntry = 0;

        // Define a place to hold the sum of the numbers
        int sum = 0;

        // loop through our process threee times
        //      Use a for-loop 
        //
        // Syntax of a for loop:
        //                      (1)                        (2a)                    (2b)
        //              initalization part      ; loop-condition-part       ;increment 
        //          for(int var = initial-value; variable < #-times-to-Loop; varaible++) {
        //  }                        

        // The for-loop is controlled by the variable defined within it:
        //
        //  1. int variable=initial-value - initialize the variable (usually to 0)
        //  2. the condition following the varaible definition is tested:
        //      a. if true - perform the process between the {} for the for-loop
        //     b. 
        //      c. if false - exit the loop after the closing brace }
        // 
        for (int i = 0; i < 3; i++)
        {


            // Ask the user to enter a number
            Console.Write("Enter a number:");
            // Get the number they enter
            string theResponse = Console.ReadLine(); // Get data from keyboard
            firstEntry = int.Parse(theResponse); //Convert data to an int

            // Alternate way to get the number without using the string variable
            //Combine multiple statements into one!
            //               firstEntry = int.Parse(Console.ReadLine());

            // Add the number to the sum
        

        sum = sum + firstEntry; // sum += first entry 
            Console.WriteLine("The sum of all your wonderful numbers is: " + sum);
            Console.WriteLine("-----End Program----");

        }
    }
