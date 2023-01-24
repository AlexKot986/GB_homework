/*  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */

Random random = new Random();
int num = random.Next(1, 100000);

Console.WriteLine($"{num} -> {SumOfNumbers(ToArrayNum(num))}");

int[] ToArrayNum(int number)
{
    int size_number = 0;
    int clone_num = number;
    for (int i = 0; clone_num != 0; i++)
    {
        clone_num /= 10;
        size_number++;
    }
    int[] array_nym = new int[size_number];
    for (int i = array_nym.Length - 1; i >= 0; i--)
    {
        array_nym[i] = number % 10;
        number /= 10;
    }
    return  array_nym;
}

int SumOfNumbers(int[] array)
{
    int sum = 0;
    foreach (int x in array)
    sum += x;
    return sum;
}