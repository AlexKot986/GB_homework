// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(4, 6), random.Next(4, 6)];
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] arr = CreateArray();
int number = 1;
void FillArray(int row, int col)
{
    if (arr[row, col] == 0)
    {
        arr[row, col] = number++;

        if ((col + 1 >= 0 && col + 1 < arr.GetLength(1) && arr[row, col + 1] == 0) && (row - 1 >= 0 && row - 1 < arr.GetLength(0)))
            FillArray(row - 1, col);
            
        if (col + 1 >= 0 && col + 1 < arr.GetLength(1))
            FillArray(row, col + 1);

        if (row + 1 >= 0 && row + 1 < arr.GetLength(0))
            FillArray(row + 1, col);

        if (col - 1 >= 0 && col - 1 < arr.GetLength(1))
            FillArray(row, col - 1);

        if (row - 1 >= 0 && row - 1 < arr.GetLength(0))
            FillArray(row - 1, col);
    }
}

PrintArray(arr);

FillArray(0, 0);
Console.WriteLine();
PrintArray(arr);
