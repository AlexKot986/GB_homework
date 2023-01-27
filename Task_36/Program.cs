// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(1, 21)];
    for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-20, 21);
    return array;
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
      sum += array[i];
      
    Console.Write("[" + string.Join(" ", array));
    return sum;
}

Console.WriteLine("] -> " + SumOddIndex(CreateArray()));
