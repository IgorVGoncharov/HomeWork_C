// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

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

void ElementSearching(int[,] arr, int line, int column) //поиск элемента по индексу
{
    int searchingLine = line - 1;
    int searchingColumn = column - 1;
    if (searchingLine >= arr.GetLength(0) || searchingColumn >= arr.GetLength(1))
    {
        System.Console.WriteLine("Элемента на указанной позиции нет");
    }
    else
    {
        System.Console.WriteLine(
            $"Желаемый элемент в указанной позиции: {arr[searchingLine, searchingColumn]}"
        );
    }
}

int line = promt("Введите число строк в массиве: ");
int column = promt("Введите число столбцов в массиве: ");
int[,] newarray = NewArray(line, column);
PrintMultiArray(newarray);
System.Console.WriteLine();
int desiredLine = promt("Введите номер строки (где находится желаемый элемент): ");
int desiredColumn = promt("Введите номер столбца (где находится желаемый элемент) ");
ElementSearching(newarray, desiredLine, desiredColumn);
