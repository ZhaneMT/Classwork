using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();
            
            // Lets add 3 students - loop 3 times for-loop
            // add students and grades until user is done.
            //Looop until the user satisfies a condition instead of a specific # of times.
            //Replace the for-loop with either a while-loop or do-while()
            // Do we want to loop at least once? Yes -dowhile loop; No - while loop
            //Is Ok to loop 0-tomes? yes -while loop; No - do-while loop
            //
            //In this case we have to ask the user at least once, to enter some data. 
            //How do we want the user to let us know they are done
            //Create an on/off switch
            //Prompt - ask if they are done
            // Set a condition based on what 
            // Define data used in the loop BEFORE the loop so its accessible
            //      both 
            string userResponse = "";
            do  
            {
               
                //Get a response from the user and convert lower case
               
                //string userResponse = Console.ReadLine().ToLower();
                
                
                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                Console.Write("Enter grade: ");
                //Because the user might enter a non-numeric grade causing an exception
                //WE should handle the exception so the program doesnt end 
                //  with a message that will scare the human 
                // We can use a try/catch to handle the exception.
                // When the user enters a non-numeric grade:
                //  1. Ignore it!
                                // remove the student or not even put them in the book
                //  2. Give them another chance to enter it
                //  3. Set the grade to 0 

                double grade = 0; //A statement inside this try block might cause an exception
                string userGrade = "";
                List<double> grades = new List<double>();
                
                try // A statement inside this try block might cause an exception
                {   //A statement inside this try block might cause an exception 
                    // We need to get multiple grafes for each student and store them in a list
                    string whatTheyTyped = "";
                    while (whatTheyTyped != "end")
                    {
                        Console.Write("Enter grade or end: ");
                    }
                    whatTheyTyped = Console.ReadLine();
                    if (whatTheyTyped != "end")
                    {
                        break; // exit the loop - continue would be OK too
                    }
                    grade = Double.Parse(userGrade); // Get student grade\
                    grades.Add(grade);
                    //grade = Double.Parse(Console.ReadLine());
                }
                // at the end of this loop the grades list has all the grades
                catch (FormatException exceptionObject) //if it throws a Format exception
                {
                    Console.WriteLine("The data entered " + ( userGrade )+ " is not a valid number.");
                    Console.WriteLine("The data is ignored");
                    //Skip adding the student to the dictionary (skip the rest of the loop process)
                    continue; // skip the rest of the loop processing 
                }
                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                
                gradeBook[studentName] = grade; // adding the lsit of grades for the student 
                //Get a response 
               
                //We are checking userResponse AFTER we get it from the user
               // We need to find out if they have more students to enter
               // We want to be sure they only enter responses we expect
               // Loop until we get a valid response
               // for-loop - do we know how many times we want to loop? NOO
               // while - Do we loop based on a condition? YES - Can we loop 0 times? 
               // do-while - Do we loop based on a condition? YES -Do we need loop at least once? - YES

               /*
               if (userResponse != "y" || userResponse != "n")
                {
                    Console.WriteLine("Sorry we only accept 'y' or 'n'.");

                }
                else
                {
                    Console.WriteLine("Sorry we only accept 'y' or 'n'.");
                    userResponse = Console.ReadLine();
                }
                */
               do
               {
                   Console.WriteLine("Are you done? (y/n)");
                   // Get a response from the user and convert to lowercase
                   userResponse = Console.ReadLine();
                   // We are checking userResponse AFTER we get it from the user
               } while (userResponse != "y" && userResponse != "n");
               
            } while (userResponse != "y"); // Loop while they are not done (done = "y").
            
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, List<double>> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " );
                foreach (double grade in anEntry.Value)
                {
                    Console.WriteLine(grade);
                }
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}