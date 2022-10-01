Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"max = {a}, min = {b} " );
}
else if (b > a)
{
    Console.Write($"max = {b}, min = {a} " );
}
else
{
    Console.Write("Число 1 = числу 2");
}