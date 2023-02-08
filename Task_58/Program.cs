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
    int[,] matrix = new int[random.Next(2, 3), random.Next(2, 3)];
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
}

// int[] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int m;
//     int indx = 0;
//     int[] multi = new int[matrix1.Length];

//     {
//         m = 0;
//         for (int row = 0, col = 0; row < 2; row++, col++)
//         {
//             m = m + matrix1[0, col] * matrix2[row, 0];
//         }

//         multi[indx++] = m;
//     }

// return multi;

// }


int[,] firstMatrix = {{2, 4},
                      {3, 2},};

int[,] secondMatrix ={{3, 4},
                      {3, 3}};
string str = "";
string MultiplyMatrix(int a, int b)
{
    int m;

    //int[] multi = new int[firstMatrix.Length];

    m = 0;
    for (int row = 0, col = 0; row < 2; row++, col++)
    {
        m = m + firstMatrix[a, col] * secondMatrix[row, b];
    }

    //if (n < 2)
    str = str + m.ToString() + " ";// + MultiplyMatrix(n + 1);
    //else return "";
    m = 0;
    for (int row = 0, col = 0; row < 2; row++, col++)
    {
        m = m + firstMatrix[a, col] * secondMatrix[row, b + 1];
    }
    str = str + m.ToString() + " ";

    m = 0;
    for (int row = 0, col = 0; row < 2; row++, col++)
    {
        m = m + firstMatrix[a + 1, col] * secondMatrix[row, b];
    }
    str = str + m.ToString() + " ";

    m = 0;
    for (int row = 0, col = 0; row < 2; row++, col++)
    {
        m = m + firstMatrix[a + 1, col] * secondMatrix[row, b + 1];
    }
    str = str + m.ToString() + " ";



    return str;
}




// int[,] firstMatrix = CreateMatrix();
// int[,] secondMatrix = CreateMatrix();

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);

Console.WriteLine(MultiplyMatrix(0, 0));//string.Join(" ", MultiplyMatrix(firstMatrix, secondMatrix)));
//MultiplyMatrix(firstMatrix, secondMatrix);





