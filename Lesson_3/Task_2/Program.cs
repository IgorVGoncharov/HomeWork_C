//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();

const int x = 0;
const int y = 1;
const int z = 2;

int promt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoin(int point) // заполнение трехмерного массива
{
    int[] result = new int[3];
    result[x] = promt($"Введите x{point}: ");
    result[y] = promt($"Введите y{point}: ");
    result[z] = promt($"Введите z{point}: ");
    return result;
}

int square(int arg) // считает квадрат введенного числа
{
    return arg*arg;
}

int[] pointOne = InputPoin(1); // вводим координаты точки 1
int[] pointTwo = InputPoin(2); // вводим координаты точки 2

double result = Math.Sqrt(square(pointTwo[x]-pointOne[x]) + square(pointTwo[y]-pointOne[y]) + square(pointTwo[z]-pointOne[z]));
// считаем расстояние от точки 1 до точки 2 

System.Console.WriteLine($"{result:f2}");
