// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача №7 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Например:
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputNumLine != null)
{
    // Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);

    int lastDigit = imputNumberA % 10;

    Console.WriteLine(lastDigit);

}
