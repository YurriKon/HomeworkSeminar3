
// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Random rand = new Random();
int N = rand.Next(1,10);
int i = 1;
Console.WriteLine($"{N}:");
while (i <= N)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}