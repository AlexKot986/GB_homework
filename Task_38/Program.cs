// Задача 38: Задайте массив целых чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(5, 11)];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1, 6);
    Console.Write("[" + string.Join(" ", array));
    return array;
}

int MinNumber(int[] array, out int max)
{
    max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] > max) max = array[i + 1];
        else if (array[i + 1] < min) min = array[i + 1];
    }

    return min;
}
int max;
int min;

min = MinNumber(CreateArray(), out max);

Console.WriteLine("] -> " + (max - min));

