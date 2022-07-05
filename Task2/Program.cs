// программa принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
void printDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double difX = x2 - x1;
    double difY = y2 - y1;
    double difZ = z2 - z1;
    double distance3D = Math.Sqrt(difX * difX + difY * difY + difZ * difZ);
    System.Console.WriteLine(distance3D);

}

Console.WriteLine("Input coordinate X of the first point");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate Y of the first point");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate Z of the first point");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate X of the second point");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate Y of the second point");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate Z of the second point");
double z2 = Convert.ToDouble(Console.ReadLine());

printDistance3D(x1, y1, z1, x2, y2, z2);



