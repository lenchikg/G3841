﻿// Задача 68: 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}


//ошибка
// Stack overflow.
// Repeat 19279 times:
// --------------------------------
//    at Program.<<Main>$>g__Akkerman|0_1(Int32, Int32)
// --------------------------------
//    at Program.<Main>$(System.String[])