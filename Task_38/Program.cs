// Задача 38: Задайте массив целых чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(5, 21)];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 11);
    return array;
}

 int MaxNumber(int[] array, out int min)
 {
     int max = array[0];
     min = array[0];

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] > max) max = array[i + 1];
        else if (array[i + 1] < min) min = array[i + 1];
    }
    return max;
}

int min;
int[] random_array = CreateArray();

Console.Write("[" + string.Join(", ", random_array) + "] -> " + (MaxNumber(random_array, out min) - min));