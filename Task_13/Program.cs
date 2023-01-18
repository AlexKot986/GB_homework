/*  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
string str = "";
int count = 0;
while (num != 0)
{
    str = str + (num % 10);
    num /= 10;
    count++;
}
if (count < 3)
    Console.Write(number + " -> третьей цифры нет");
else
    Console.WriteLine(number + " -> " + str[str.Length - 3]);
