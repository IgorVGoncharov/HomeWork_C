// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


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
    System.Console.WriteLine("Одномерный массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int SummOddElements(int[] arr) // подсчет суммы элементов, стоящих на нечетных позициях
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        summ = summ + arr[i];
    }
    return summ;
}

int[] array = CreateArray(promt("Введите размерность массива: "), -100, 100);
PrintArray(array);
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {SummOddElements(array)}");