//Assignment 1 13-02-2026 
// Hello from repo

Console.WriteLine("Please enter the invoice amount");

double amount = Convert.ToDouble(Console.ReadLine());

if (amount < 0)
{
    Console.WriteLine($"Invalied Amount {amount}");
} 
else if (amount >= 500)
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

// another way to solve it

Console.WriteLine("Please enter the invoice amount");
double _amount = Convert.ToDouble( Console.ReadLine() );

double discountPercentage = 0.0;
double discountAmount = 0.00;
double finalAmount = 0.00;

if (_amount < 0)
{
    Console.WriteLine($"Invalied Amount {_amount}");
} else if (_amount <= 50)
{
    discountPercentage =  0.2;
} else if (_amount < 500 && _amount >= 300)
{
    discountPercentage =  0.1;
}

discountAmount = _amount * discountPercentage;
finalAmount = _amount - discountAmount;
string transDate = (DateTime.UtcNow).ToString("dd-MMM-yyyy");
Console.WriteLine($"The final amount after discount {discountPercentage * 100}% is: {finalAmount}");
Console.WriteLine($"Transaction happened at: {transDate}");
