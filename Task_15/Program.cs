// программа принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Write("Введите число дня недели от 1 до 7: ");
var day = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
if (day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day - 1]);
}

