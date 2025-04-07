namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        
        /***************************************
         * Strings in C# are a special data type - they don't work like you think they should.
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is; 1.1.24 "Bob"
         *
         * string variables sometimes require special processing
         *      you can't use <> to compare strings
         *      Beware; Early versions of C# do not allow you to use == with strings
         *
         * C# provides several methods to operate on strings:
         *
         *          .Equals(string) - compare the string to the left of the . to string inside()
         *          .CompareTo(string) - return a number indicating how the first string relates to the second
         *          return a negative number if first string is less than the second
         *          return a zero if first string is equal to the second.
         *          return a positive number if first string is greater than the seceond
         **************************************/
        // if (condition) {
        // what to do if condition is true
        //    }
        // else {
        // What to do if condition is false
        string string1 = "a";
        string string2 = "a";
        if (string1.CompareTo(string2) > 0)         //see if the first string is greater than the second
        {
            Console.WriteLine(" String1 is freater than string2");
        }
        else
        {
            Console.WriteLine("They are not equals");
        }
    }
}