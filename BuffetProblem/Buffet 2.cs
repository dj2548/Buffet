//Let's simulate a buffet experience!
//You will create a program that simulates the host of a buffet restaurant.
//The program will ask the user for a party size,
//ask for each party member’s drink order,
//keep track of how many times each drink was ordered,
//and at the end, present a bill with the accurate total price.

//This is an all - you - can - eat buffet,
//so the price for each person is the same.
//(Set the buffet price to $9.99 per person.)
//The guests only pay extra for drinks... and this buffet only has two drinks!
//You can choose the two drinks and their prices. (For example, water is free, and coffee is $2.00).

Console.WriteLine(" Hello. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Parties of 6 or lower only.");

string speople = Console.ReadLine();
int numPeople = int.Parse(speople);
decimal buffet = 9.99m;
int coffeePrice = 2;
int numcoffee = 0;
int numwater = 0;

if (numPeople > 6)
{

    Console.WriteLine("Sorry you have too many people. We only seat tables of 6 or under have a nice day.");

}else{

    Console.WriteLine("Come on in! \n");
    
    bool run = true;

    string input;
    

    for(int i = 1; i <= numPeople; i++)
    {
        Console.WriteLine("Alright, person number " + i + ", water or coffee?");
        input = Console.ReadLine();

        if(input == "coffee" || input == "Coffee")
        {
            //
            numcoffee++;
            Console.WriteLine("Coffee, good choice!");
        }else if(input == "water" || input == "Water")
        {
            //
            numwater++;
            Console.WriteLine("Water, good choice!");
        }
        else
        {
            Console.WriteLine("Sorry we dont have that. No drink for you! \n" );
        }

        
       
        
    }
    //generate a bill
    Console.WriteLine(" Okay so thats " + numcoffee + " coffees and " + numwater + " waters, ill be right back. Feel free to grab your food!");

    //calculate price
    decimal price = 0;

    price = ((numPeople * buffet) + (numcoffee * coffeePrice));
    price = Decimal.Round(price, 2);
    Console.WriteLine("Here's your bill! Total price: $" + price);
} 