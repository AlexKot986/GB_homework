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
    if (number.ToString().Length >= num)
        Console.WriteLine(number + " -> " + number.ToString()[num - 1]);
    else Console.WriteLine(number + " -> такой цифры нет");
}

TakeNumber(number, num);
