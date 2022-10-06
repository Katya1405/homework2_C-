// Найти расстояние между точками в пространстве 2D/3D
// для нахождения расстояния в пространстве 2D просто вводите z = 0 

Console.Write("введите координату x1 для первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("введите координату y1 для первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("введите координату x2 для второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("введите координату y2 для второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("введите координату z1 для третьей точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("введите координату z2 для третьей точки: ");
int z2 = int.Parse(Console.ReadLine());

int result = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2 + (z2 - z1) ^ 2) ^ (1 / 2);
Console.WriteLine("Расстояние между точками = " + result);