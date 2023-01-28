// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(1, 21)];
    for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(100, 1000);
    return array;
}

int ShowNumber(int[] array)
{
    int count = 0;
    foreach (int x in array)
    if (x % 2 == 0) count++;
    return count;
}

int[] random_array = CreateArray();
Console.WriteLine("[" + string.Join(", ", random_array) + "] -> " + ShowNumber(random_array));