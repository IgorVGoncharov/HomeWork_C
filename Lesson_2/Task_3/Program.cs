//Задача 3: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lenght = Convert.ToString(number).Length;
int repit = 1;
while (repit < lenght-2)
{
    number = number / 10;
    repit++;
}
if (lenght < 3)
{
    System.Console.WriteLine("Третьей цифры нет!");
}
else
{
    System.Console.WriteLine($"Третья цифра заданного чисола: {number%10}");
}

