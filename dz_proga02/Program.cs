// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
int x3 = (x1 - x2) * (x1 - x2);
int y3 = (y1 - y2) * (y1 - y2);
int z3 = (z1 - z2) * (z1 - z2);

double result = Math.Sqrt(x3 + y3 + z3);
double result1 = Math.Round(result, 2);
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {result1}");