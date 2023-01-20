/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53   */

//D=sqrt((X2-X1)^2+(Y2-Y1)^2+(Z2-Z1)^2)

Random rand = new Random();

int x1 = rand.Next(-100, 101), y1 = rand.Next(-100, 101), z1 = rand.Next(-100, 101);
int x2 = rand.Next(-100, 101), y2 = rand.Next(-100, 101), z2 = rand.Next(-100, 101);

Console.WriteLine($"Point A  ({x1}, {y1}, {z1})");
Console.WriteLine($"Point B  ({x2}, {y2}, {z2})");

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(Math.Round(length,2));



Console.WriteLine("Введите координаты точки 1: ");
string[] sArr = Console.ReadLine().Split(' ');
int a1 = Convert.ToInt32(sArr[0]);
int b1 = Convert.ToInt32(sArr[1]);
int c1 = Convert.ToInt32(sArr[2]);

Console.WriteLine("Введите координаты точки 2: ");
string[] sArr2 = Console.ReadLine().Split(' ');
int a2 = Convert.ToInt32(sArr2[0]);
int b2 = Convert.ToInt32(sArr2[1]);
int c2 = Convert.ToInt32(sArr2[2]);

//double result = ;
Console.Write("{0:#.00}", Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2)));