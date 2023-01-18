/*  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите цифру числа: ");
int num = Convert.ToInt32(Console.ReadLine());

void TakeNumber(int number, int num)
{
    int clone_number = number;
    int size = 0;
    for (int i = 0; clone_number != 0; i++)
    {
        clone_number /= 10;
        size++;
    }
    clone_number = number;
    int[] arr = new int[size];
    for (int i = size -1; i >= 0; i--)
    {
        arr[i] = clone_number % 10;
        clone_number /= 10;
    }
    if (size >= num)
        Console.WriteLine(number + " -> " + arr[num - 1]);
    else Console.WriteLine(number + " -> такой цифры нет");
}

TakeNumber(number, num);
