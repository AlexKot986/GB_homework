// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int ToFindMinSumRow(int[,] array, out int minIndx)
{
    int sum;
    minIndx = 0;
    int[] sums = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        sums[i] = sum;

    }
    for (int k = 0; k < sums.Length - 1; k++)
    if (sums[minIndx] > sums[k + 1]) minIndx = k + 1;

    Array.Sort(sums);
    return sums[0];
}

int minIndx;

int[,] arr = CreateArray();
PrintArray(arr);

Console.WriteLine($"Наименьшая сумма: {ToFindMinSumRow(arr, out minIndx)} строка № {minIndx + 1}");




