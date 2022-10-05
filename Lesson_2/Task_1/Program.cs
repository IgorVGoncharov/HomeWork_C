//Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = Convert.ToString(number).Length;
if (length != 3)
{
    System.Console.WriteLine("Введено не трехзначное число!");
}
else
{
    System.Console.WriteLine((number / 10) % 10);
}
