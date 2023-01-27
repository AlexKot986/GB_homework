// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(1, 21)];
    for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(100, 1000);
    //Console.WriteLine(string.Join(" ", array));
    Console.Write("[");
    return array;
}

int ShowNumber(int[] array)
{
    int count = 0;
    foreach (int x in array)
    if (x % 2 == 0) count++;
    Console.Write(string.Join(", ", array));
    return count;
}

Console.WriteLine("] -> " + ShowNumber(CreateArray()));