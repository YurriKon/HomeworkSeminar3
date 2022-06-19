// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Entry:
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
if (number.Length < 5) goto Entry;
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число не является палиндромом");
}