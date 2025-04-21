namespace ShoppingListLab;

class Program
{
    /*Task: Make a shopping list application which uses collections to store your items. (You will be using two collections, one for the menu and one for the shopping list.)
       
       What will the application do?
       Display at least 8 item names and prices.
       Ask the user to enter an item name
       If that item exists, display that item and price and add that item to the user’s order.
       If that item doesn’t exist, display an error and re-prompt the user.  (Display the menu again if you’d like.)
       After adding one to their order, ask if they want to add another. If so, repeat.  (User can enter an item more than once; we’re not keeping track of quantity at this point.)
       When they’re done adding items, display a list of all items ordered with prices in columns.
       Display the sum price of the items ordered
     * 
     */
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Chirpus Market!");
        Console.WriteLine("Item             Price");
        Console.WriteLine("=============================");
        // Create a dictionary for the name of fruit then the price
        Dictionary<string,double> items = new Dictionary<string,double>();
        items.Add("apple", 0.99);
        items.Add("banana", 0.59);
        items.Add("cauliflower", 1.59);
        items.Add("dragonfruit", 2.19);
        items.Add("elderberry", 1.79);
        items.Add("figs", 2.09);
        items.Add("grapefruit", 1.99);
        items.Add("honeydew", 3.49);
        
        foreach (KeyValuePair<string,double> food in items)
        {
            Console.WriteLine(food.Key +"     "+ "$" + items[food.Key]);
        }
        List<string> shoppingList = new List<string>();
        // CREATE LIST TO COLLECT ALL ITEMS IN SHOPPING LIST
        string userContinue = "y"; // DEFAULT TO YES
// WE CAN"T START THE PROGRAM WITHOUT THE PROGRAM STARTING WITH YES. 
        while (userContinue.ToLower() == "y")
        {
            Console.WriteLine("What item would you like to order?");
            
            string userItem = Console.ReadLine().Trim().ToLower();

            if (items.ContainsKey(userItem))
            {
                Console.WriteLine("Adding "+ userItem + " to cart at $" +items[userItem]);
                shoppingList.Add(userItem);
            }
            else
            {
                Console.WriteLine("Sorry, we don't have those. Please try again.");
                continue;
            }

            Console.WriteLine("Would you like to order anything else (y/n)?");
            userContinue = Console.ReadLine().ToLower().Trim();
            // USE TRIM TO SHORTEN "Yes", "No", ETC.
        }
        double total = 0; // INITIALIZE THE TOTAL
        Console.WriteLine("Thanks for your order!");
        Console.WriteLine("Here's what you got:");
       
// CREATE A FOR-LOOP TO ADD EACH ITEM TOGETHER, WE USE
        foreach (string item in shoppingList)
        {
            
            double price = items[item];
            Console.WriteLine(item + " - $" + items[item]);
            total += items[item];
        }

        if (shoppingList.Count > 0)
        {
            double average = total / shoppingList.Count;
            
            Console.WriteLine("Average price per item in order was: " + "$" + average);
        }
        else
        {
            Console.WriteLine("No items were ordered.");
        }
    }
} // END OF CODE