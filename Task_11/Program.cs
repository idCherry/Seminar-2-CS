

int number = new Random().Next(100, 1000); 
Console.WriteLine($"Number = {number}"); 
int firstDigit = number / 100; 
int therdDigit = number % 10; 
Console.Write($"New Number = {firstDigit}{therdDigit}");
