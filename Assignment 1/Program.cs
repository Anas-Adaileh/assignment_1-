//Assignment 1 13-02-2026 
// Hello from repo

Console.WriteLine("Please enter the invoice amount");

double amount = Convert.ToDouble(Console.ReadLine());

if (amount >= 500)
{
    amount = amount * (1 - 0.2);
    Console.WriteLine($"Final Price: {amount}");
}
else if (amount >= 300 && amount <= 499)
{
    amount = amount * (1 - 0.1);
    Console.WriteLine($"Final Price: {amount}");
}
else if (amount < 300)
{
    Console.WriteLine($"Final Price: {amount}");
}
