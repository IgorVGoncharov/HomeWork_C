// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Постарайтесь сделать одним циклом

Console.Clear();

int length(string message) // ввод размерности массива
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [] array = new int [length("Введите размерность массива: ")];

int [] fill(int len) //наполняет массив
{
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

void Print(int [] mas) //выводит массив на экран
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write($"{mas[i]} ");
    }
}

Print(fill(array.Length));

int FindSecMax (int [] array) //ищет второе максимальное число
{
    int max = array[0];
    int secmax = array[1];
    for (int i=1; i < array.Length; i++)
    {
        if (max == secmax)
        {
            if (array[i] != max)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else
                {
                    secmax = array[i];
                }
            }
        }
        else
        {
            if (array[i] != max)
            {
                if (array[i] > max)
                {
                    secmax = max;
                    max = array[i];
                }
                else
                {
                    if(array[i] > secmax)
                    {
                        secmax = array[i];
                    }
                }
            }
        }
    }
    return secmax;
}


System.Console.WriteLine();
System.Console.WriteLine($"Второй максимум равен: {FindSecMax(array)}");