// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void IntersectionPoint()
{
    Console.WriteLine("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Уравнение первой прямой: y = {0} * x + {1}", k1, b1);
    Console.WriteLine("Уравнение второй прямой: y = {0} * x + {1}", k2, b2);

    double x, y;

    x = (b2 - b1) / (k1 - k2);

    y = k1 * x + b1;

    Console.WriteLine("Точка пересечения прямых: x = {0}, у = {1}", x, y);
}

IntersectionPoint();



