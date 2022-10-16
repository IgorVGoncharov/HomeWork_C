//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[] CreateArray(int len, int minLimit, int maxLimit) // создание массива из случайных числ
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (double) rnd.Next(minLimit, maxLimit)/10; 
    }
    return array;
}

void PrintArray(double[] arr) // печать массива
{
    System.Console.WriteLine("Массив вещественных числ:");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();
}

double MaxFind(double[] arr) // поиск максимального значения массива
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double MinFind(double[] arr) // поиск минимального значения массива
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double MaxMinDif(double max, double min) // разница между минимальным и максимальным значением
{
    return max - min;
}

double[] array = CreateArray(promt("Введите размерность массива: "), 0, 100);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {MaxMinDif(MaxFind(array), MinFind(array)):f1}");
