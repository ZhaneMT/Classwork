namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an array to hold 3 numbers
        int[] numbers = new int[3];
        
        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");

        // Ask for the numbers one at time using the C# Console object
        //     which represents the keyboard and screen
        // Console.ReadLine() returns a string from keyboard - cannot store in an int
      
        // int.Parse(string) will convert a string to an int
        
        //Normally we process an array from beginning to end
        // (from the first element to last element, one at a time)
        //
        //a for-loop will loop through a process counting as it does so
        //a for-loop is an excellent tool for processing an array from start to end
        //
        // standard syntax: for (i=0; i < arrayName.Length; i++)
        //
        // arrayName.Length represents the number of elements in the array 
        
        //      index
        for (int i = 0; i < numbers.Length; i++) //i = 0, 1, 2 inside loop and 3 when exit
        {
            Console.WriteLine("Please enter a number:  "); // Asking for the number
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        //Verift the array recieved the numbers correctly
        //Go through the array one element at a time and display the element
        for (int i = 0; numbers.Length > i; i++)
        {
            Console.WriteLine("Element #" + i + " is " + numbers[i]);
            sum = sum + numbers[i];
        }
        
        // Add the numbers together create a sum/total
        //sum = number1 + number2 + number3 + number4 + number5;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is:  " + sum);
        // Tell the requester the average of the numbers
        // Divide the sum by the number of elements in the array (arrayname.Length)
        Console.WriteLine("The average of the numbers is: " + (double)sum / numbers.Length);
        // sum/ numbers. Length
        // int / int ------> integer arithmetic - divide gives two parts quotient and remainder
        //      int                                         7/3 - quotient=2 remainder=1
        //(double) sum / numbers.Length
        //convert sum
        //to double / int -------> floating point arithmetic
        //             / conver int to double (C# does this automatically)
        //  double      / double ----> floating point arithmetic
        //              double (2.333333)
        Console.WriteLine(sum);
        Console.WriteLine("--- Ending program ---");
    }
}