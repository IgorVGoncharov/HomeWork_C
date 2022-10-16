// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray(int len, int minLimit, int maxLimit) // создание массива из случайных числе
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit);
    }
    return array;
}

void PrintArray(int[] arr) // печать массива
{
    System.Console.WriteLine("Массив из трехзначных цифр:");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int AmountPosNumb(int[] array) // подсчет количества четных чисел
{
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            value++;
        }
    }
    return value;
}

int[] array = CreateArray(promt("Введите размерность массива: "), 100, 1000);
PrintArray(array);
System.Console.WriteLine($"Количество четных элементов в массиве = {AmountPosNumb(array)}");
