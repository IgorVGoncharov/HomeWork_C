// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (и в нулевую степень). 
//Использовать свои функции, не использовать Math.Pow

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int exponent(int numbOne, int numbTwo) //Функция возведения в степень
{
    int result = 1;
    for (int i=1; i <= numbTwo; i++)
    {
        result = result * numbOne;  
    }
    return result;
}

int numbA = promt("Введите число А: ");
int numbB = promt("Введите число B: ");
System.Console.WriteLine($"Число А возведенное в степнь В = {exponent(numbA, numbB)}");
