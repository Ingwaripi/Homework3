// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance( int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    // double dist = Math.Sqrt((xc2 - xc1)*(xc2 - xc1)+(yc1 - yc2)*(yc1 - yc2));
    // return dist;
    return Math.Sqrt((xc2 - xc1)*(xc2 - xc1)+(yc2 - yc1)*(yc2 - yc1)+(zc2 - zc1)*(zc2 - zc1));
}
Console.Write("Введите первое значение x : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение y : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение z : ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение x : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение y : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение z : ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(res,2));