//This is a comment - everything after the is ignored
/*
 * This is a block comment - everything between the slash-asterisk and asterisk-slash
 * 
 */
namespace First_Project;

//Everything is C# is defined in a class
//a class is group of related things
// A class starts with the class keyword
class Program
//{} surrounds blocks of related things
{ //Start of code for the class
    //Every application has a "method" called Main()
    // a method is a set of code that performs a function
    // also known as: a  function or a program
    //a method may return a value and accept data to process
    // method signature identifies what the method returns, its name, and what it accepts.
    //      return-type name (data-it-accepts)
    //Main() is where every application starts
    //Every application has one and only one Main() method
    
    //Below Main() is a method that returns void and accepts strings[] called args
    //
    // void means it returns nothing
    // static means there can only be one of these in the block or code (Program class)
    //      return 
    //      type    name(data-it-accepts)
    static void Main(string[] args) //method signature 
    {
        // Start of the code for Main()
        // This code will display whatever is between the ("") on the screen

        // Console is an object defined by C# to represent the screen.
        // An object has certain behaviors 
        // A behavior is something an object can do with data. 
        // Behaviors are implemented using methods.

        // object.method(data) - object oriented programming
        //
        // when you see a . after a name, the name to the left of the . is probably an object
        //                     name(  , the name is a method)
        //                     name after the ., the name is usually a method
        //  object.method(data-for-the-method-to-process)

        Console.WriteLine("Its Alive!!!"); // EVERY C# STATEMENT ENDS WITH A SEMICOLON ;
     // End of the code for the Main()
    }// End of code for the class
        
}
