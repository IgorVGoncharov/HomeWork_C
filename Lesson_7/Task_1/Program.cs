// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] NewArray(int line, int col) // создание нового массива из случаных чисел
{
    double[,] newarray = new double[line, col];
    Random random = new Random();
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = random.Next(-50, 50) / 10.0;
        }
    }
    return newarray;
}

void PrintMultiArray(double[,] arr) // печать многомерного массива
{
    System.Console.WriteLine();
    System.Console.WriteLine("Двумерный массив случайных вещественных чисел:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int line = promt("Введите число строк в массиве: ");
int column = promt("Введите число столбцов в массиве: ");
double[,] newarray = NewArray(line, column);
PrintMultiArray(newarray);
