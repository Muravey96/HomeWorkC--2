﻿/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
void UserNumberCheck(int num)
{
    if (num == 6 || num == 7) 
    {
        Console.WriteLine("Выходной");
    }
    else Console.WriteLine("Иди работать!");
}
UserNumberCheck(num);
