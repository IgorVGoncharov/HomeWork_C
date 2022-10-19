// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] NewArray(int length) // ввод чисел пользователем + формирование массива
{
    System.Console.WriteLine();
    int[] array = new int[length]; 
    for (int i = 0; i < length; i++)
    {
        array[i] = promt($"Введите число {i+1}: ");
    }
    System.Console.WriteLine();
    return array;
}

int NumPos(int[] array) // подсчет количества положительных цифр
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

int len = promt("Введите количество числел для рассчета: ");
int[] array = NewArray(len);
System.Console.WriteLine($"Количество положительных чисел = {NumPos(array)}");