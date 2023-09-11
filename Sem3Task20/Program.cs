//Задача №20 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

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

//Вычисляем расстояние между точками в 2D пространстве
double CalcLen(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}

//вводим координаты точек
int coordX1 = ReadData("Введите координату X1");
int coordX2 = ReadData("Введите координату X2");
int coordY1 = ReadData("Введите координату Y1");
int coordY2 = ReadData("Введите координату Y2");

//Вычисляем длину
double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

//Выдаём результат
PrintData("Расстояние между точками: ", len);

//Так тоже можно, но трудно читаемо.
// PrintData("Расстояние между точками: ", CalcLen(
//     ReadData("Введите координату X1"), 
//     ReadData("Введите координату X2"),
//     ReadData("Введите координату Y1"),
//     ReadData("Введите координату Y2")));