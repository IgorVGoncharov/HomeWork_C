// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintMultiArray(int[,] arr) // печать многомерного массива
{
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

bool ArrayControl(int[,] firstarr, int[,] secarr) //проверка возможности условия произведения матриц
{
    if (firstarr.GetLength(1) == secarr.GetLength(0))
    {
        return true;
    }
    return false;
}

int[,] ArrayProduct(int[,] firstarr, int[,] secarr) //произведение матриц
{
    int max = 0;
    if (firstarr.GetLength(0) > secarr.GetLength(1))
    {
        max = firstarr.GetLength(0);
    }
    else
    {
        max = secarr.GetLength(1);
    }
    int[,] array = new int[firstarr.GetLength(0),secarr.GetLength(1)];
    for(int i = 0; i < firstarr.GetLength(0); i++)
    {
        for (int n = 0; n < max; n++)
        {
            int sum = 0;
            for (int j = 0; j < firstarr.GetLength(1); j++)
            {
                sum = sum + firstarr[i,j] * secarr[j,n];
                array[i,n] = sum;
            }

        }
    }
    return array;
}

int line = promt("Введите число строк в матрице 1: ");
int column = promt("Введите число столбцов в матрице 1: ");
int[,] firstarray = NewArray(line, column);
PrintMultiArray(firstarray);
System.Console.WriteLine();
int secline = promt("Введите число строк в матрице 2: ");
int seccolumn = promt("Введите число столбцов в матрице 2: ");
int[,] secarray = NewArray(secline, seccolumn);
PrintMultiArray(secarray);
System.Console.WriteLine();
if (ArrayControl(firstarray,secarray))
{
    System.Console.WriteLine("Произведение двух матриц:");
    PrintMultiArray(ArrayProduct(firstarray,secarray));    
}
else
{
    System.Console.WriteLine("Произведение не возможно, т.к. количество столбцов матрицы 1 должно быть равно количеству строк матрицы 2.");
}
 


