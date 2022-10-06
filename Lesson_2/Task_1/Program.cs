//Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <1000)
{
    System.Console.WriteLine($"Вторая цифра числа: {(number / 10) % 10}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}

