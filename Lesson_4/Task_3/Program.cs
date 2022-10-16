// Задача 3: Напишите программу, которая задаёт массив
// из 8 случайных элементов и выводит их на экран.
// ++ Сделал для произвольной размерности ++

Console.Clear();

int length(string message) // ввод размерности массива
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] array = new int[length("Введите размерность массива: ")];

int[] fill(int len) //наполняет массив
{
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void Print(int[] mas) //выводит массив на экран
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write($"{mas[i]} ");
    }
}

Print(fill(array.Length));
