Dictionary<string, decimal> items = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase) // makes dictionaries no longer case-sensitive
{
    {"Gum",1.50m},
    {"Soda",2.50m},
    {"Water",2.0m},
    {"Skittles",1.50m},
    {"Root beer",2.50m},
    {"Gatorade",2.50m},
    {"Snickers", 1.50m},
    {"Reeses",1.50m},
};

List<string> inputList = new List<string>();
decimal totalPrice = 0;

Console.WriteLine("Welcome to Rebeccah's vending machine!");
Console.WriteLine("Here are your options:");

foreach (var item in items)
{
    Console.WriteLine($"{item.Key} - {item.Value:c}"); // :c indicates currency
}

bool addAnother;
do
{
    Console.WriteLine("Which would you like to buy?");
    string selectedItem = Console.ReadLine();

    bool doesItemExist = items.ContainsKey(selectedItem.ToLower());

    while (doesItemExist == false)
    {
        Console.WriteLine("That item doesn't exist. Try again");
        selectedItem = Console.ReadLine();
        doesItemExist = items.ContainsKey(selectedItem.ToLower());
    }

    inputList.Add(selectedItem.ToLower()); // adding the user input to the order (stored in the list)
    totalPrice = totalPrice + items[selectedItem.ToLower()];
    Console.WriteLine($"You have ordered {selectedItem} for {items[selectedItem]:c}"); // displays the item added to the order and the price of the item
    Console.WriteLine("Would you like to order another item or stop? (add/stop)");
    string userInput = Console.ReadLine();
    addAnother = userInput.ToLower().Trim() == "add";

} while (addAnother == true);

Console.Clear(); // will clear the window
Console.WriteLine("Here is what you ordered");
foreach (string item in inputList)
{
    Console.WriteLine($"{item} {items[item]:c}");
}

Console.WriteLine($"Your total is {totalPrice:c}");

// How are lists and arrays different from each other?

// Both lists and arrays require the developer to specify a type when they are declared, but they handle the data differently. Array types are strict and unable to be changed
// at a later time and have a fixed size, while lists allow you to reuse the same list for different types and have the ability to grow/shrink in size as needed.




