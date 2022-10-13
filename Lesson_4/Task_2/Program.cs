// Задача 2: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int digitSum(int numb) // подсчет суммы цифр введенного числа
{
    int result = 0;
    while (numb > 0)
    {
        result = result + numb % 10;
        numb = numb / 10;
    }
    return result;
}

int number = promt("Введите число: ");
System.Console.WriteLine($"Сумма цифр введенного числа = {digitSum(number)}");
