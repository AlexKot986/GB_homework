/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет   */

string WeekDays(int number)
{
    string str = "";
    switch (number)
    {
        case 1: Console.Write(str = "Понедельник");
        //str = "Понедельник";
        break;
        case 2: Console.Write(str = "Вторник");
        break;
        case 3: Console.Write(str = "Среда");
        break;
        case 4: Console.Write(str = "Четверг");
        break;
        case 5: Console.Write(str = "Пятница");
        break;
        case 6: Console.Write(str = "Суббота");
        break;
        case 7: Console.Write(str = "Воскресенье");
        break;
        default: Console.Write("Такого дня недели нет!");
        break;
    }
    return str;
}
void IsWeekEnd(string str)
{
    switch (str)
    {
        case "Понедельник":
        case "Вторник":
        case "Среда":
        case "Четверг":
        case "Пятница": Console.WriteLine(" - это будний день!");
        break;
        case "Суббота":
        case "Воскресенье": Console.WriteLine(" - это выходной день!");
        break;
     //   default: Console.WriteLine("  жаль(");
     //   break;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
IsWeekEnd(WeekDays(num));

