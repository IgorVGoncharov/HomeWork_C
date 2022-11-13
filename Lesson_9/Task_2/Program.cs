//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Clear();

int Promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FindSumm(int firstnumb, int secnumb) // Возвращает сумму натуральных элементов от M до N
{
    if (firstnumb > secnumb)
    {
        return 0;
    }
    return firstnumb + FindSumm(firstnumb + 1, secnumb);
}

int firstnumb = Promt("Введите число M: ");
int secnumb = Promt("Введите число N: ");
int sum = FindSumm(firstnumb, secnumb);
System.Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N равна: {sum}");

