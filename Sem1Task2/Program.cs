// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3


Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1 + " больше " + number2);
}
else if (number1 < number2)
{
    Console.WriteLine(number1 + " меньше " + number2);
}
else
{
    Console.WriteLine(number1 + " равно " + number2);
}

//Второй вариант
// int number1, number2;
// Console.Write("Введите первое число: ");
// number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
// Console.WriteLine("Первое число больше.");
// }
// else if (number1 < number2)
// {
// Console.WriteLine("Второе число больше.");
// }
// else
// {
// Console.WriteLine("Первое и второе число равны.");
// }
// Console.ReadLine();
