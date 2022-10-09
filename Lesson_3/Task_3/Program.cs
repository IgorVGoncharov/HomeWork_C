// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = promt("Введите число: ");

for (int i=1; i <= number; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}

