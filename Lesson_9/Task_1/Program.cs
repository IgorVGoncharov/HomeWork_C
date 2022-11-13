//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
//натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

Console.Clear();

int Promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintNumbers(int firstnumb, int secnumb) //функция вывода четных натуральных чисел
{
    if (firstnumb > secnumb)
    {
        return;
    }
    if (firstnumb % 2 == 0)
    {
        System.Console.Write(firstnumb + " ");
        PrintNumbers(firstnumb + 2, secnumb);
    }
    else
    {
        PrintNumbers(firstnumb + 1, secnumb);
    }
}

int firstnumb = Promt("Введите число M: ");
int secnumb = Promt("Введите число N: ");
PrintNumbers(firstnumb, secnumb); 