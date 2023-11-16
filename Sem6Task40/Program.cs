// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

int a = ReadData("Введите второе число a: ");
int b = ReadData("Введите второе число b: ");
int c = ReadData("Введите второе число c: ");

//метод ввода кода элмента, который нужно найти
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

if (a+c>b && a+b>c && b+c>a)
{
   Console.WriteLine("Треугольник посторить можно");
}
else
{
    Console.WriteLine("Треугольник посторить нельзя");
}