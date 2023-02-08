// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix()
{
    Random random = new Random();
    int[,] matrix = new int[random.Next(3, 4), random.Next(3, 4)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 6);
        }
    }
    return matrix;
}

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


int[,] firstMatrix = CreateMatrix();

int[,] secondMatrix = CreateMatrix();

int[,] MultiplyMatrix()
{
    int[,] multi = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int a = 0; a < multi.GetLength(0); a++)
    {
        for (int b = 0; b < multi.GetLength(1); b++)
        {
            int m = 0;
            for (int row = 0, col = 0; row < firstMatrix.GetLength(0); row++, col++)
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
PrintMatrix(MultiplyMatrix());





