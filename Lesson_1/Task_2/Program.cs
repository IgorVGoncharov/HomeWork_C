Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
if (number1 == number2 || number1 == number3)
{
    Console.Write("Все числа равны");
}
else
{
    Console.Write($"Максимальное из этих чисел: {max}");
}
