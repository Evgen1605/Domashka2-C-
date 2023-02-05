// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите число: ");

string num = Console.ReadLine()!;
if (num.Length < 3 || num.Length > 3)
{
  Console.Write("Неправильное число: ");
  return;
}
string otvet = Convert.ToString(num[num.Length - 2]);
Console.Write($"Вторая цифра: {otvet}");
