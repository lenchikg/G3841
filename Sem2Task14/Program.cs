// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine() ?? "0"); //преобразование ASCII. ??-нулсейфти, чтобы небыло пустых значений.
int res1 = num1 % 7;
// int num2 = int.Parse(Console.ReadLine() ?? "0");
int res2 = num1 % 23;
if ((res1 == 0) && (res2 == 0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}