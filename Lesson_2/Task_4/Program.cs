//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    System.Console.WriteLine("Цифра не обозначает день недели");
}
else
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine("Этот день является выходным");
    }
    else
    {
        System.Console.WriteLine("Этот день не является выходным");
    }
}
