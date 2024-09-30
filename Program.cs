// Main
int number = 8; //rows long
Random rnd = new Random();  //random number generator
//End Main

Console.WriteLine("Pizza Menu:");
Console.WriteLine("1 - Plain Pizza");
Console.WriteLine("2 - Cheese Pizza");
Console.WriteLine("3 - Pepperoni Pizza");
Console.Write("Please make a selection: ");

string choice = Console.ReadLine();

if (choice == "1")
{
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number - i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
else if (choice == "2")
{
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number - i; j++)
        {
            if (i == 0 || j == 0 || j == number - i - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("# ");
            }
        }
        Console.WriteLine();
    }
}
else if (choice == "3")
{
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number - i; j++)
        {
            if (i == 0 || j == 0 || j == number - i - 1)
            {
                Console.Write("* ");
            }
            else if (rnd.Next(2) == 0)  //pepperoni
            {
                Console.Write("[] ");
            }
            else
            {
                Console.Write("# ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Invalid choice. Please run the program again and select 1, 2, or 3.");
}