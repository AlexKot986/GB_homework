// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int[] numbers = new int[0];
int[] OrderDigits(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) 
    {
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = firstNumber;
        return numbers;
    }
    Array.Resize(ref numbers, numbers.Length + 1);
    numbers[numbers.Length - 1] = firstNumber;
    return OrderDigits(firstNumber - 1, secondNumber);
}

int numFirst = new Random().Next(0, 11);
int numSecond = new Random().Next(0, 11);

int min, max;
if (numFirst < numSecond) {min = numFirst; max = numSecond;}
else {max = numFirst; min = numSecond;}

Console.WriteLine($"Числа от {max} до {min} = -> {string.Join(" ", OrderDigits(max, min))}");