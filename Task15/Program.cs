/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool Weekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 &&  number <= 7)
    {
        return true;
    }
    return false;
}

int weekDay = InputNum("Введите число: ");
if (ValidateWeekday(weekDay))
    if (Weekend(weekDay))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
