// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int numFirst, int numSecond)
{
    if (numFirst == numSecond) return numSecond;
    return numFirst + SumNumbers(numFirst + 1, numSecond);
}
int firstNum = new Random().Next(0, 11);
int secondNum = new Random().Next(0, 11);

int min, max;
if (firstNum < secondNum) {min = firstNum; max = secondNum;}
else {max = firstNum; min = secondNum;}

Console.WriteLine($"Сумма чисел от {min} до {max} = -> {SumNumbers(min, max)}");