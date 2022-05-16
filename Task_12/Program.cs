// На вход - два числа, выводит кратно ли первое число второму, если нет, то вывести остаток от деления

Console.Write("Первое число - > ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Второе число - > ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0) Console.WriteLine("Первое число кратно второму");
else Console.WriteLine($"Первое число не кратно второму, остаток от деления -> {num1 % num2}");

