/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
void SearchForCoordinates(int[] CoordinatesA, int [] CoordinatesB)
{
    double result = 0;
    for (int i = 0; i < CoordinatesA.Length; i++) 
    {
         result = result + Math.Pow((CoordinatesA[i]-CoordinatesB[i]),2);
    }
    Console.WriteLine($"A ({CoordinatesA[0]}, {CoordinatesA[1]}, {CoordinatesA[2]}) B ({CoordinatesB[0]}, {CoordinatesB[1]}, {CoordinatesB[2]}) - > {Math.Round(Math.Sqrt(result),2)}");
}

int [] arr1 = new int[3];
Console.WriteLine("Ввеедите координаты первой точки A (x, y, z): ");
    for (int i = 0; i < arr1.Length; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        arr1[i] = number; 
    }
    int [] arr2 = new int[3];
Console.WriteLine("Ввеедите координаты первой точки B (x, y, z): ");
    for (int i = 0; i < arr2.Length; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        arr2[i] = number; 
    }
SearchForCoordinates(arr1,arr2);