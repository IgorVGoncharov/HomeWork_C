//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintMultiArray(int[,] arr) // печать многомерного массива
{
    System.Console.WriteLine();
    System.Console.WriteLine("Двумерный массив случайных чисел:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] NewArray(int line, int col) // создание нового массива из случаных чисел
{
    int[,] newarray = new int[line, col];
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = new Random().Next(1, 10);
        }
    }
    return newarray;
}

void SearchForAverage(int[,] arr) // поиск среднего арифметического
{
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int result = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result += arr[i, j];
        }
        double average = result / (arr.GetLength(0) * 1.0);
        System.Console.WriteLine($"Столбец {j + 1}: {average:f1} ");
    }
}

int line = promt("Введите число строк в массиве: ");
int column = promt("Введите число столбцов в массиве: ");
int[,] newarray = NewArray(line, column);
PrintMultiArray(newarray);
System.Console.WriteLine();
SearchForAverage(newarray);
