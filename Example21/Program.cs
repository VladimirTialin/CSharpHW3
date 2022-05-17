/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
void SearchForCoordinates(int xA,int yA,int zA, int xB, int yB, int zB)
{
    double result = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB)+(zA-zB)*(zA-zB));
        Console.WriteLine($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}) - > {Math.Round(result,2)}");
}
Console.WriteLine("Введите координаты первой точки A (x, y, z): ");
int xA =Convert.ToInt32(Console.ReadLine());
int yA =Convert.ToInt32(Console.ReadLine());
int zA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки B (x, y, z): ");
int xB =Convert.ToInt32(Console.ReadLine());
int yB =Convert.ToInt32(Console.ReadLine());
int zB =Convert.ToInt32(Console.ReadLine());
SearchForCoordinates(xA,yA,zA,xB,yB,zB);
