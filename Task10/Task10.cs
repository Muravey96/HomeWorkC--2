/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 456 -> 5
 782 -> 8
 918 -> 1 */



Console.Write("Введите трехзначное число: ");
int userInput = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(userInput);
Console.WriteLine($"{userInput}->" +num2[1]); 