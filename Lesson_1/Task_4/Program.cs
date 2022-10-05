Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;
Console.Write("Все четные числа от 1 до N: ");
while (start <= N)
{
    if (start % 2 == 0)
    {
        if (start == 2)
        {
            Console.Write($"{start}");
        }
        else
        {
            Console.Write($", {start}");
        }
    }
    start = start + 1;
}
