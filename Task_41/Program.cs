// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());


void CountNumbersToHeands(int number)
{
    int[] array = new int[number];
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Введите число {0}: ", (i + 1));
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    Console.WriteLine(string.Join(" ", array) + " -> " + count);
}

CountNumbersToHeands(m);