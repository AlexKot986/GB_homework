// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] AverageNumberInColumn(int[,] array)
{
    double averageNumber;
    double[] averageNumberArray = new double[array.GetLength(1)];

    for (int row = 0; row < array.GetLength(1); row++)
    {
        averageNumber = 0;
        for (int col = 0; col < array.GetLength(0); col++)
        {
            averageNumber = averageNumber + array[col, row];
        }
        averageNumberArray[row] = Math.Round(averageNumber / array.GetLength(0), 2);
    }
    return averageNumberArray;
}
int[,] arr = CreateArray();
PrintArray(arr);

Console.WriteLine("Среднее арифметическое каждого столбца: " + string.Join("; ", AverageNumberInColumn(arr)));