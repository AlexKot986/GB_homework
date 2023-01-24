/*  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */
Random random = new Random();
int a = random.Next(1, 10);
int b = random.Next(1, 10);
Console.WriteLine("{0}, {1} -> {2} ({0}^{1})", a, b, ToDegreeOfNumber(a, b));

int ToDegreeOfNumber(int number, int degree)
{
    int number_deg = number;
    for (int deg_ind = 2; deg_ind <= degree; deg_ind++) //deg_ind - индекс степени
    {
        number_deg = number_deg * number;
    }
    return number_deg;
}

