/*   Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]  */

void ToSeeArray()
{
    int[] array = new int[new Random().Next(1, 10)];

    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);

    foreach (int x in array)    
    Console.Write(x + ", ");
    Console.Write("\b\b -> [");

    foreach(int x in array)
    Console.Write(x + ", ");
    Console.WriteLine("\b\b]");
}
ToSeeArray();