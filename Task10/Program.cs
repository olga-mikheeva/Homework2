﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
    
int SecondDigit(int number)
{
    int secondDigit = (number / 10) % 10;
    return secondDigit;
}

int num = InputNum("Введите трехзначное число: ");
int res = SecondDigit(num);
Console.WriteLine(res);
