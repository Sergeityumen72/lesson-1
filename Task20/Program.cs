// Задача 20: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int a1, int a2, int b1, int b2)
{
    int side1 = a1 - b1;
    int side2 = a2 - b2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2);
    return distance;
}


Console.WriteLine("Введите координаты 1-ой точки");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты 2-ой точки");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(result);
