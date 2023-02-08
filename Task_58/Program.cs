// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] firstMatrix = {{2, 4},
                      {3, 2},};

int[,] secondMatrix ={{3, 4},
                      {3, 3}};

int[,] MultiplyMatrix(int a, int b)
{
    int[,] multi = new int[2,2];

    for (a = 0; a < 2; a++)
    {
        for (b = 0; b < 2; b++)
        {
            int m = 0;
            for (int row = 0, col = 0; row < 2; row++, col++)
            {
                m = m + firstMatrix[a, col] * secondMatrix[row, b];
            }
            multi[a, b] = m;
        }
    }
    return multi;
}
Console.WriteLine("Даны 2 матрицы:");
PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine("Произведение двух матриц:");
PrintMatrix(MultiplyMatrix(0, 0));





