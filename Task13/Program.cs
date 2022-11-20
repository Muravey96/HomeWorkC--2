/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введи число: ");
int userInput = Convert.ToInt32(Console.ReadLine());
string num3 = Convert.ToString(userInput);
if (num3.Length > 2)
{
  Console.WriteLine($"{userInput} -> " + num3[2]);
}
else 
{
  Console.WriteLine($"{userInput} -> третьей цифры нет");
}