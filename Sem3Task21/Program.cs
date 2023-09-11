// №21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

//Метод, который читает данные от пользователя. чтобы не заставлять вводить каждую точку отдельно. Метод с входными и выходными параметрами.
int ReadData(string msg)
{
    Console.WriteLine(msg); // Вводим данные с консоли
    return int.Parse(Console.ReadLine() ?? "0"); //возвращаем
}

//Вводим результат пользователю
void PrintData(string msg, double res)

{
    Console.WriteLine(msg + res);
}

//Вычисляем расстояние между точками в 3D пространстве
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return res;
}

//вводим координаты точек
int coordX1 = ReadData("Введите координату X1");
int coordX2 = ReadData("Введите координату X2");
int coordY1 = ReadData("Введите координату Y1");
int coordY2 = ReadData("Введите координату Y2");
int coordZ1 = ReadData("Введите координату Z1");
int coordZ2 = ReadData("Введите координату Z2");

//Вычисляем длину
double len = CalcLen(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2);

//Выдаём результат
PrintData("Расстояние между точками: ", len);


// или Так. Вариант 2. длина отрезка отличается. возможно где то косяк.


// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");