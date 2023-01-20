/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да   */

bool IsPalindrome(int number)
{
    int count = 0;
    int clone_number = number;
    for (int i = 0; clone_number > 0; i++)
    {
        clone_number /= 10;
        count++;
    }
    int[] number_array = new int[count];
    for (int i = number_array.Length - 1; number > 0; i--)
    {
        number_array[i] = number % 10;
        number /= 10;
    }

    count = 0;
    for (int i = 0, j = number_array.Length - 1; i < j; i++, j--)
    {
        if (number_array[i] == number_array[j])
            count++;
    }
    if (count == number_array.Length / 2)
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

