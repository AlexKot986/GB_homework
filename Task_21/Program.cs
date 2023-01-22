/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53   */

//D=sqrt((X2-X1)^2+(Y2-Y1)^2+(Z2-Z1)^2)

Random random = new Random();

double TwoPointLenght(int[] a, int[] b)
{
    double length = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2));
    return length;
}
Console.WriteLine("Введите координаты точки A: ");
int[] point_a = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
int ax = Convert.ToInt32(point_a[0]);
int ay = Convert.ToInt32(point_a[1]);
int az = Convert.ToInt32(point_a[2]);

//Console.WriteLine("Координаты точки B: ");
int[] point_b = {random.Next(-100, 101), random.Next(-100, 101), random.Next(-100, 101)};
int bx = Convert.ToInt32(point_b[0]);
int by = Convert.ToInt32(point_b[1]);
int bz = Convert.ToInt32(point_b[2]);

Console.WriteLine($"Точка A  ({ax}, {ay}, {az})");
Console.WriteLine($"Точка B  ({bx}, {by}, {bz})");

Console.Write("{0:#.00}", TwoPointLenght(point_a, point_b));