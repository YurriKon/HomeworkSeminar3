
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Random rand = new Random();
int x1 = rand.Next(1,10);
int y1 = rand.Next(1,10);
int z1 = rand.Next(1,10);
int x2 = rand.Next(1,10);
int y2 = rand.Next(1,10);
int z2 = rand.Next(1,10);
Console.WriteLine($"A({x1},{y1},{z1}), B({x2},{y2},{z2})");
double K1 = Math.Pow(x1-x2, 2);
double K2 = Math.Pow(y1-y2, 2);
double K3 = Math.Pow(z1-z2, 2);
double AB = Math.Sqrt(K1 + K2 + K3);
Console.WriteLine($"Расстояние между А и В равно {AB}");
