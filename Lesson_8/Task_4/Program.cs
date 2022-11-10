//Напишите программу, которая заполнит спирально квадратный массив.

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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateArray(int line) // создание и спиральное заполнение массива
{
    int[,] array = new int[line,line];
    int numb = 1;
    for (int var = 0; var < line/2; var++)
    {
        for(int j = var; j < line-1-var; j++)
        {
            array[var, j] = numb;
            numb++;
        }
        for (int i = var; i < line-1-var; i++)
        {
            array[i, line-1-var] = numb;
            numb++;
        }
        for (int f = line-1-var; f > var; f--)
        {
            array[line-1-var, f] = numb;
            numb++;
        }
        for (int g = line-1-var; g > var; g--)
        {
            array[g, var] = numb;
            numb++;
        }
    if (line%2 != 0)
    {
        array[line/2, line/2] = numb;
    }
    }
    return array;
}

int line = promt("Введите размерность квадратного массива: ");
if (line < 2)
{
    System.Console.WriteLine("Введите размерность больше 1.");
}
else
{
    PrintMultiArray(CreateArray(line));
}

