// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string OrderDigits(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber.ToString();
    return OrderDigits(firstNumber, secondNumber + 1) + " " + secondNumber;
}

int numFirst = new Random().Next(5, 11);
int numSecond = new Random().Next(0, 6);

Console.WriteLine($"Числа от {numFirst} до {numSecond} = -> {OrderDigits(numFirst, numSecond)}");