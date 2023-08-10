/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

int InputNum(string message)
{
    Console.WriteLine(message);
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

int weekDay = InputNum("Введите число от 1 до 7: ");
if (Weekend(weekDay))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
