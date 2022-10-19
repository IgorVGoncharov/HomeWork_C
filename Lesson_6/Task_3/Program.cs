// Задача 3: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

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
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    
}

void PrintArray(int[] arr) // печать одномерного массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[,] NewArray(int line, int col) // создание нового массива из случаных чисел
{
    int[,] newarray = new int[line, col];
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i,j] = new Random().Next(1, 6);
        }
    }
    return newarray;
}

int[] FindLineMax(int[,] arr) // поиск максимальных элементов в строках
{
    int[] newarray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int max = arr[i,0];
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] > max)
            {
                max = arr[i,j];
            }
            
        }
        newarray[i] = max;
    }   
    return newarray;
}

int[] FindColMin(int[,] arr) // поиск минимальных элементов в столбцах
{
    int[] newarray = new int[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int min = arr[0,j];
        for (int i = 1; i < arr.GetLength(1); i++)
        {
            if (arr[i,j] < min)
            {
                min = arr[i,j];
            }
            
        }
        newarray[j] = min;
    }   
    return newarray;
}

int Sum(int[] arr) // подсчет суммы элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}


int line = promt("Введите число строк в массиве: ");
int column = promt("Введите число столбцов в массиве: ");
int[,] newarray = NewArray(line,column);
int max = Sum(FindLineMax(newarray));
int min = Sum(FindColMin(newarray));
int result = max - min;
PrintMultiArray(newarray);
System.Console.WriteLine();
System.Console.WriteLine("Максимальные элементы в строках:");
PrintArray(FindLineMax(newarray));
System.Console.WriteLine();
System.Console.WriteLine("Минимальные элементы в столбцах:");
PrintArray(FindColMin(newarray));
System.Console.WriteLine();
System.Console.WriteLine($"Результат вычета из суммы максимумов строк ({max}) сумм минимумов столбцов ({min}) = {result} ");