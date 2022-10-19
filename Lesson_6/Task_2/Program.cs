// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindIntersecPoint(double b1, double b2, double k1, double k2) // функция поиска точек пересечения
{
    if ((b1-b2) == 0 && (k2-k1) == 0)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Прямые совпадают");
    }
    else if ((k2-k1) == 0)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Прямые паралельны");
    }
    else
    {
    double x = (b1-b2) / (k2-k1);
    double y = (k1*x) + b1;
    System.Console.WriteLine();
    System.Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
   }
}

double b1 = promt("Введите b1: ");
double k1 = promt("Введите k1: ");
double b2 = promt("Введите b2: ");
double k2 = promt("Введите k2: ");
FindIntersecPoint(b1, b2, k1, k2);
