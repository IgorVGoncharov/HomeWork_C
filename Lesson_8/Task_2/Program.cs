// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int StringElementsSum(int[,] arr, int str) // считаeт сумму элементов заданной строки
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[str, j];
    }
    return sum;
}

int FindMinSumStrig(int[,] arr) // возвращает строку с наименьшей суммой элементов
{
    int minsum = StringElementsSum(arr, 0);
    int minstr = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (StringElementsSum(arr, i) < minsum)
        {
            minsum = StringElementsSum(arr, i);
            minstr = i;
        }
    }
    return minstr;
}

int line = promt("Введите число строк в массиве: ");
int column = promt("Введите число столбцов в массиве: ");
int[,] newarray = NewArray(line, column);
PrintMultiArray(newarray);
System.Console.WriteLine();
System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {FindMinSumStrig(newarray)}");