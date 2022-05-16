// программа принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Write("Введите число, соответствующее дню недели -> ");
int num = int.Parse(Console.ReadLine());

while (num < 8) 
{
    if (num == 6 || num == 7) Console.WriteLine("Выходной день");
    else Console.WriteLine("Не выходной день");
    break;
}
while (num > 7) 
{
    Console.WriteLine("Нет такого дня недели"); 
    break;
}
