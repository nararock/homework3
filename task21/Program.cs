// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Первая точка");
int[] A = enterPoint();
Console.WriteLine("Вторая точка");
int[] B = enterPoint();
var result = Math.Round(Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2) + Math.Pow((A[2] - B[2]), 2)), 2);
Console.WriteLine(result);

int[]  enterPoint(){
    Console.WriteLine("Введите x: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите z: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    int [] point = {x1, y1, z1};
    return point;
}  
