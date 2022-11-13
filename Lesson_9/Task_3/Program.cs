//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AnkermanFunc(int m, int n) //фнукция Анкермана
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0) 
    {
        return AnkermanFunc(m - 1, 1);
    }
    else
    {
        return AnkermanFunc(m - 1, AnkermanFunc(m, n-1));
    }
}

int firstnumb = Promt("Введите число M: ");
int secnumb = Promt("Введите число N: ");
if (firstnumb < 0 || secnumb < 0)
    {
        System.Console.WriteLine("Необходимо ввести не отрицательное число.");
    }
    else
    {
        int result = AnkermanFunc(firstnumb, secnumb);
        System.Console.WriteLine($"Результат вывода функции Анкермана A(m,n) = {result}");

    }