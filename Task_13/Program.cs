/*  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 3;

void TakeNumber(int number, int num)
{
    if (number.ToString().Length >= num)
        Console.WriteLine(number + " -> " + number.ToString()[num - 1]);
    else Console.WriteLine(number + " -> третьей цифры нет");
}

TakeNumber(number, num);
