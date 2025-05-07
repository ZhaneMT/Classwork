namespace Day_1_Student_Class_Example;

// internal attribute was removed so we can use the class anywhere

// public - anyone can use this class
// class - this is the definition of a C# class
// Student - name of the class - Classname are in PascalCase

// A class is a description of an object used in object oriented programming
// A class contains data (class member/class data and methods (class methods)
// A class is a programmer defined data type (much like int, string, double, List<>)
// Because it is a PROGRAMMER defined data type, the programmer is responsible for:
//
//     the data in the class
//     the methods that manipulate the class data (behaviors of the object)
//
//  class can do whatever a programmer decides it should or shouldn't do
//public is used so any one can istaniate objects of the class

// This class represents a student and their test scores
public class Student
{
    // Define the data for our class
    // private indicates only members of the class can access the data
    // private implements the Object-Oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                 only methods in the class can access the data
    //
    //                 Users of the class access the data using methods
    //                 defined in the class.
    //
    // Note: The data is defined without an initial value
    //       Class data should be initialized in constructors
    private string    studentName;
    private List<int> testScores;
    
    // Define methods for the class
    
    // One special methods for a class is called a constructor
    // A constructor is responible for initializingthe data in a class
    // (data should never be uninitialized - the starting value needs to be known)
    
    // a constructor method is special because:
    //
    //   1. it has no return type; not even void
    //   2. it has the same name as the Class
    //   3. it may or may not receive parameters (initializers)
    //      ( a constructor with no parameters is called a default constructor)
    //   4. Usually public 
    
    // Define a constructor to initialize our data with values 
    //          specified by the user

    // As the class Designer YOU decide what you need to properly initialize objects of the class
    // YOU decided how constructors you need or how users of the class can initialize your objects.
    //
    // Default valu eis a value used when the real value is not known
    //
    // Do we want to allow an object with default values?
    //      Does is make sense to not have a defaukt student name default student scores?
    //              No - Dont code a default ctor to initialize with default values.
    //              Yes -  Code a 0-arg ctor that takes the name and assignes it studentName 
    //                                                  and assigns an empty list to testScores

    public Student(string theName) // 1-arg constructor to accept a name only
    {
        studentName = theName;
        testScores = new List<int>();
    }
    
    
    public Student(string name, List<int> scores) // 2 -arg constructor
                                                // two parameters ysed to initialize an object
    {
        studentName = name;  // Set the class data to the data passed in from the user
        testScores = scores; // Set the class data to the data passed in from the user
    }
    
    // Provide a method to display our data
    // (Console.WriteLine() doesn't know how to do it)
   
    /********************************************************************
     * METHODS TO MALUPULATE THE CLASS
     ******************************************************************/
    
    // We need a method to allow the user to add scores to our testScores List
    // Every method requires a method signature and a body
    // Method signiture :   access  return
    //                      type    type
// When creating a method you do        Method body: Inside {} following method signature. 
    public void AddScore(int score)
    {
        testScores.Add(score);
    }
    // Allow the user to get the sum of the scores
    // WE need a method to add up the scores and return
    public double SumOfScores() // No args needed  needed as we have access to all the data we need in class
    {
        //Define a variable to hold what we returning
        double sum = 0;
        
        // Two ways we can do this:
        //  1.Use a for each loop
        //  2. See if there is method for List that do the sum for us
                    //(There seems to be a method we could use, but it looks complicated )

                    foreach (double score in testScores)
                    {
                        sum = sum + score; // sum += 
                    }

                    return sum;
    }

    public double AvgOfScores()
    {
        return Math.Round(SumOfScores() / testScores.Count, 2);
    }
    
    
    
    public void ShowStudent()
    {
        Console.WriteLine("\nName: " + studentName);
        Console.Write("Scores: ");

        foreach (int score in testScores)
        {
            Console.Write(score + " "); //Display on same line
        }
    }
    /*
     *
     *
     *
     */
    public string GetStudentName()
    {
        return studentName; // return the value in this private member
    }

    public List<double> GetTestScores()
    {
        return testScores; // return the value in this privacte data member
    }
    
    /*************************************************
    Methods to manipulate strubg
     *********************************************
     * We need to provide a ToString() method 
     * 
     */
    
}