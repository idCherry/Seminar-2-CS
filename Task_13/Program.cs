// Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Конечно странный код, учитывая, что каждый раз нужно прописывать диапазон и менять res,
// но другого варианта у меня нет

Console.Write("Введите цифру -> ");
int num = int.Parse(Console.ReadLine());
int res = (num / 10) % 10;
int res1 = (num / 100) % 10;
int res2 = (num / 1000) % 10;

if (num < 100) Console.WriteLine("Третьей цифры нет");
if (num >= 1000 && num < 10000) Console.WriteLine($"Третья цифра числа -> {res}");
if (num >= 10000 && num < 100000) Console.WriteLine($"Третья цифра числа -> {res1}");
if (num >= 100000 && num < 1000000) Console.WriteLine($"Третья цифра числа -> {res2}");
