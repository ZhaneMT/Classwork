﻿namespace NumberAnalyzer;
/*
 *NUMBER ANALYZER - Decision Maker
 * 
   1 Point: The application prompts the user to enter an integer between 1 and 100
   Display the associated result based on the integer range entered.
   Build Specifications:
   1. 1 Point: Use if/else statements to take diﬀerent actions depending on user input.
   2. Given an integer entered by a user, perform the following conditional actions:
   a. 1 Point: If the integer entered is odd and less than 60, print the number
   entered and “Odd and less than 60.
   ”
   b. c. d. e. 1 Point: If the integer entered is even and in the inclusive range of 2 to 24, print
   “Even and less than 25.
   ”
   1 Point: If the integer entered is even and in the inclusive range of 26 to 60,
   print “Even and between 26 and 60 inclusive.
   ”
   1 Point: If the integer entered is even and greater than 60, print the number
   entered and “Even and greater than 60.
   ”
   1 Point: If the integer entered is odd and greater than 60, print the number
   entered and “Odd and greater than 60.
   ”
   Additional Requirements:
   1 Point: For answering the Lab Summary when submitting to the LMS
   -2 Points: if there are any syntax errors or if the program does not run (for example, in
   a Main method).
   Hints:
   Remember what “inclusive” and “exclusive” mean when referring to ranges of numbers.
   The range of numbers from 1 inclusive to 10 exclusive means the numbers 1, 2, 3, 4, 5,
   6, 7, 8, 9 (but not 10; it’s excluded).
   Extra Challenges (2 Points Maximum):
   1 Point: Set up the program to continue running with a prompt at the end to see if
   they want to stop. (hint: Loops)
   1 Point: Ask for user information (ex. name) at the beginning of the application, and
   use it to refer to the user throughout the application.
   1 Point: Add validation to guarantee that a user enters a positive integer between 1
   and 100.
 * 
 */
public class Class1
{
  static void Main(string[] args)
  {
    // We need a initialized variable for the user's chosen number:
    Console.WriteLine("------START OF PROGRAM------");
    Console.Write("Enter an integer between 1 and 100: ");
    string Line = Console.ReadLine();
    
    
    Console.WriteLine("-----END OF PROGRAM-------");
  }
}