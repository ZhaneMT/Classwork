namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence
        //      (series of words seperated by whitespace - space, tab, something you can't see)
        // Display each word in the sentence 
        
        Console.WriteLine("Please enter a sentence: ");
        string sentence = Console.ReadLine();  // Get what they type and put it in a string
        //  split the sentence into each individual word
        //      .split() will extract parts of a string into an array based on character/word.

        List<string> splitSentence = sentence.Split(" ").ToList(); //Converts an array to a list
        //                                              --------- 
        
        
        
        
        
        
        //string[] splitSentence = sentence.Split(" "); // splits the sentence by each individual word.
        
        //Display the array, specifically each word
        //      we can do this by using a for loop
        // arrayName.Length returns the number of elements
        
        //for (int i = 0; i < splitSentence.Length; i++) //To process an array use .Length to get # of elements
       for (int i=0; i < splitSentence.Count(); i++)    // To process a List - use .Count to get # of elements 
        {
            // NOTE: to add 1 to i and use in the string we must use ()
            // .WriteLine() treats everything you give it like a string.
            //  why?:    + for a string means concatenate 
            //           + for a numeric means add
            //  without the parenthesis for i+1, it thinks the value of i then add 1 at the end 
            //  This concept is called Presendents? 
            Console.WriteLine("Word #: " + (i + 1) + " is: " + splitSentence[i]);
        }
       /* for-each loop can also process Arrays and Lists  
             Syntax: foreach(datatype variable-name in array-or-List)
             datatype is the type of data in the array or List
             use the variable name inside the foreach loop to access an element in the array
        Foreach goes through the array or List from start to end assigning each element to the variable 
      
      for-loop vs for-each loop (WHAT'S THE DIFFERENCE?)
        Both -       Can process an array or list from beginning to end.
        
        For-Loop -   Can start and end at any element by setting int i= and changing the condition
                     You know which element number you're process by using the value in i.
                     
        For Each -   ALWAYS processes from the beginning to end. 
                     You DO NOT know which element number you're processing
      
      
      
       */
      Console.WriteLine("----- THE EXAMPLE OF THE FOR EACH -----"); 
       foreach (string aWord in splitSentence)
       {
           Console.WriteLine(aWord);
       }
       /* Display all the words using a do-while loop:
        *
        *   while(condition) // loop while the condition is true
        *       {
        *           loop processing
        *
        *       } while(condition) // loop while the condition is true
        *   We could do the loop process at zero 
        * 
        *  We always do the loop process at least once
        *   because the condition is checked at the end of the loop process.
        *
        *   Define a variable to keep track of the element in the array/List we are processing.
        */
       int elementNumber = 0;
        Console.WriteLine("----- TESTING FOR DO/WHILE LOOP------- ");
      //While loop example
      //while (elementNumber < splitSentence.Length)
      {
          Console.WriteLine("Word #: " + (elementNumber + 1) + " is: " + splitSentence[elementNumber]);
          elementNumber++; // increment our index variable to move through array or list.
      }


    }
}