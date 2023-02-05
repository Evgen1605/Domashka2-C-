// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int numberDayOfWeek = int.Parse(Console.ReadLine()!);
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
  Console.WriteLine("неверное число введите от 1 до 7");
  return;
}

if (numberDayOfWeek == 1)
{
  Console.WriteLine("Понедельник: рабочий день");
}
if (numberDayOfWeek == 2)
{
  Console.WriteLine("Вторник: рабочий день");
}
if (numberDayOfWeek == 3)
{
  Console.WriteLine("Среда: рабочий день");
}
if (numberDayOfWeek == 4)
{
  Console.WriteLine("Четверг: рабочий день");
}
if (numberDayOfWeek == 5)
{
  Console.WriteLine("Пятница: рабочий день");
}
if (numberDayOfWeek == 6)
{
  Console.WriteLine("Суббота: выходной день");
}
if (numberDayOfWeek == 7)
{
  Console.WriteLine("Воскресенье: выходной день");
}