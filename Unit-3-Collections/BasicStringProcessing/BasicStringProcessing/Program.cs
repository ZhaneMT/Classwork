namespace BasicStringProcessing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- STARTING PROGRAM -----"); // START OF PROGRAM
        WordList();
        
    }

    static void WordList()
    {
        /*  QUESTION 1:
           1)  Prompt the user to enter a sentence.
           2)  Split the sentence into individual words and display each word on its own line.
        */
        Console.WriteLine("Please enter a sentence: ");
        string userResponse = Console.ReadLine();
        List<string> splitResponse = userResponse.Split(" ").ToList();

        for (int i = 0; i < splitResponse.Count; i++)
        {
            Console.WriteLine(splitResponse[i]);
        }

        Console.WriteLine("Goodbye!"); //END OF PROGRAM
    } 
}
static void WordAddList()
{
    List<string> words = new List<string>();
    while (true)
    {
        Console.Write(">>Enter some text: <<");
        string input = Console.ReadLine();
        words.Add(input);

        Console.WriteLine("<<You have entered: " + string.Join(" ", words));

        Console.Write("Would you like to continue (y/n)? <<");
        string response = Console.ReadLine().ToLower();

        if (response != "y")
        {
            Console.WriteLine(">>Goodbye!");
            break;
        }
    }
}