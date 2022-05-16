// Принимаеи число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) Console.WriteLine("Число кратно 7 и 23 одновременно");
else Console.WriteLine("Число не кратно 7 и 23 одновременно");

//Console.Write("Введите число -> ");
//int num = int.Parse(Console.ReadLine());
//bool res = num % 7 == 0 && num % 23 == 0;
//Console.WriteLine(res ? "Число кратно 7 и 23 одновременно" : "Число не кратно 7 и 23 одновременно");

