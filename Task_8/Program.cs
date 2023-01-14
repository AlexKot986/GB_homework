/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 4;

if (N < 2) Console.WriteLine("Введите число больше 1!");
else

Console.Write($"Чётные числа от 1 до {N}: 2");

while (i <= N)
{
Console.Write(", " + i);
i += 2;
}