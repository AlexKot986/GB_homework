/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да   */

bool IsPalindrome(int number)
{
    int count = 0;
    for (int i = 0, j = number.ToString().Length - 1; i < j; i++, j--)
    {
        if (number.ToString()[i] == number.ToString()[j])
            count++;
    }
    if (count == number.ToString().Length / 2)
        return true;
    else
        return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
    Console.WriteLine(number + " -> Да!");
else
    Console.WriteLine(number + " -> Нет!");

