// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

	
int x1 = Coordinate("X", "A");
int x2 = Coordinate("X", "B");
int y1 = Coordinate("Y", "A");
int y2 = Coordinate("Y", "B");
int z1 = Coordinate("Z", "A");
int z2 = Coordinate("Z", "B");
	
int Coordinate(string coorName, string pointName)
	{
	Console.Write($"Введите координату {coorName} точки {pointName}: ");
	return Convert.ToInt32(Console.ReadLine());
	}
double Decision(double x1, double x2, 
	double y1, double y2, 
	double z1, double z2)
    {
	return  Math.Sqrt(Math.Pow((x2-x1), 2) + 
	        Math.Pow((y2-y1), 2) + 
	        Math.Pow((z2-z1), 2));
	}
double distance =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
	
Console.WriteLine($"Расстояние между точками: {distance}");

