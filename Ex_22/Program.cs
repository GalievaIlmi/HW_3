// // Задача 22: Найти расстояние между точками в пространстве 2D/3D
// В пространстве 2D S(расстояние м/у точуами)  = (X2-X1)^2 + (Y2-Y1)^2 
Console.WriteLine("расположение первой точки по оси x:");
int A1 = int.Parse(Console.ReadLine());

Console.WriteLine("расположение первой точки по оси y:");
int B1 = int.Parse(Console.ReadLine());

Console.WriteLine("расположение второй точки по оси x:");
int A2 = int.Parse(Console.ReadLine());

Console.WriteLine("расположение второй точки по оси y:");
int B2 = int.Parse(Console.ReadLine());
double distance = ((A1 - A2) * (A1 - A2)) + ((B1 - B2) * (B1 - B2));

Console.WriteLine($"Расстояние: {Math.Sqrt(distance)}");