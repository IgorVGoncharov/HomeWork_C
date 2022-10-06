//Задача 3: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
}
if (number < 100)
{
    System.Console.WriteLine("В введенном числе третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number=number/10;
    }
    System.Console.WriteLine($"Третья цифра заданного числа: {number%10}");
}
