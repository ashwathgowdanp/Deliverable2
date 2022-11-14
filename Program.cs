
Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee." + '\n' + 
                  "How many people are in your group? Please, parties of 6 or lower.");
int NumberOfPeople = int.Parse(Console.ReadLine());

int NumberOfWater = 0;
int NumberOfCoffee = 0;
if (NumberOfPeople > 6 ) 
        {
          Console.WriteLine("Sorry, We are not taking more than 6  people at the moment. Please try later!");
          return;
        }
decimal totalBuffetAmount = 0;
Console.WriteLine("A table for " + NumberOfPeople + "!  Please follow me and take a seat" + '\n' +
                   "Let's get everyone started with some drinks. We've got water or coffee.");
int count = 1;
for ( count = 1; count <= NumberOfPeople; count++)
{   
   Console.WriteLine("Alright, person number " + count + ", Water or Coffee");
   String drink = Console.ReadLine();
   if (drink != null)
    {
       
        if ((drink == "Water") || (drink == "water"))
        {
            Console.WriteLine(drink + ", good choice!");
            NumberOfWater = NumberOfWater + 1;
        }
        else if ((drink == "Coffee") || (drink == "coffee"))
        {
            Console.WriteLine(drink + ", Okay!");
            NumberOfCoffee = NumberOfCoffee + 1;
        }
        else
        {
            Console.WriteLine(drink + ", We dont have that. No Drink for you!");
        }
    } 
}
totalBuffetAmount = (decimal)(NumberOfPeople * 9.99) + (decimal)(NumberOfCoffee * 2.00);
Console.WriteLine("Here's your bill! Total Price: " + totalBuffetAmount);
Console.WriteLine(NumberOfPeople + " Buffets = " + NumberOfPeople + " x " + "9.99 = " + (decimal)(NumberOfPeople * 9.99));
Console.WriteLine(NumberOfCoffee + " Coffees = " + NumberOfCoffee + " x " + "2.00 = " + (decimal)(NumberOfCoffee * 2.00));
Console.WriteLine(NumberOfWater + " Waters = Free " );
Console.WriteLine("Total = " + totalBuffetAmount);