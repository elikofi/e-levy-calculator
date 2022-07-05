//Calculating how much a person will be charged if they send money above 100GHC.

do
{
    double result = 0;
    Console.Write("Enter an amount: ");
    double amount = Convert.ToDouble(Console.ReadLine());

    if (amount > 100)
    {
        result = amount * 0.015;
        Console.WriteLine($"You will be charged: {result}GHC for sending {amount}GHC.");
    }
    else
    {
        Console.WriteLine($"You won't be charged for sending {amount}GHC.");
    }
    Console.WriteLine("Do you want to make another calculation? (Y = Yes, N = No)");

} while (Console.ReadLine().ToUpper() == "Y");
Console.WriteLine("Bye");