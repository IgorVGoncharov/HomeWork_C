// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Написано для любого числа.

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int length(int numb) // возвращает длину введенного числа
{
    int len = 1;
    if (numb > -10 && numb < 10);
    else
    {
        while (numb > 9)
        {
            numb = numb / 10;
            len++;
        }
    }
    return len;
}

int divNumberOne(int len) // возвращает значение на что делить, чтобы получить первые цифры числа
{
    int length = 1;
    for (int i = len; i >= 1; i = i -1)
    {
    length  = Convert.ToInt32(Math.Pow(10, len-1));
    }
    return length;
}

int divNumberTwo(int len) //возвращает значение на что делить, чтобы получить песледнии цифры числа
{
    int length = 1;
    for(int i = 1; i <= len; i++)
    {
        length = Convert.ToInt32(Math.Pow(10, i-1));
    }
    return length;
}

string palindrome(int num, int len) //проверка, является ли число палиндромом
{
    if (len == 1)
    {
        return "Число не является палиндромом";
    }
    else
    {
    int var = 1;
    while(len/2 > 0)
    {
        int number1 = (num/divNumberOne(len))%10;
        int number2 = (num/divNumberTwo(var))%10;
        if (number1 != number2)
        {
            return "Число не является палиндромом";
        }
        len = len - 1;
        var++;
    }
    }
    return "Число является палиндромом";
}

int number = promt("Введите число: ");
System.Console.WriteLine(palindrome(number, length(number)));
