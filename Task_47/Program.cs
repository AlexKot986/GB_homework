// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void CreateArray(int num1, int num2)
{
    Random random = new Random();
    double[,] array = new double[num1, num2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((random.NextDouble() * random.Next(-100, 101)), 2);

            if (array[i, j] == 0)
            j--;
            else
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Random random = new Random();
int m = random.Next(3, 6);
int n = random.Next(3, 6);
Console.WriteLine($"m = {m}, n = {n}.");
CreateArray(m, n);