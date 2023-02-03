// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9


int[,] CreateArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(3, 6), random.Next(3, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 6);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 4}");
        }
        Console.WriteLine();
    }
}

void GetElement(int m, int n, int[,] array)
{
    if (m < array.GetLength(0) && n < array.GetLength(1)) Console.WriteLine(array[m, n]);
    else Console.WriteLine("Такого числа в массиве нет");
}

int m = new Random().Next(3, 6);
int n = new Random().Next(3, 6);
int [,] arr = CreateArray();


PrintArray(arr);

Console.Write(m + " " + n + " -> ");
GetElement(m, n, arr);