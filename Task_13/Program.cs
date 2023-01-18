/*  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

Console.Write("Введите число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(Console.ReadLine());

void TakeNumber(string str, int number)
{
    if (str.Length >= number)
        Console.WriteLine(number + " -> " + str[number - 1]);
    else Console.WriteLine(number + " -> такой цифры нет");
}

TakeNumber(str, number);