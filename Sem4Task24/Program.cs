// Задача №24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSimple(int numA)
{ 
    int sumOfNum = 1;
    for(int i=2;i<=numA;i++)  //пройдёмся в цикле и сложим по одному
    {
        sumOfNum+=i;
    }
    return sumOfNum;
}

int SumGauss(int numA)   //используем формулу Карла Гаусса
{
    return (numA*(numA+1))/2;
}

int numberA = ReadData("Введите число A");  //сама программа. получим число от пользователя

DateTime d1 = DateTime.Now; //проверка скорости работы алгоритма. фиксируем время начала.
int res1 = SumSimple(numberA); //обращаемся к нашему методу
Console.WriteLine(DateTime.Now - d1); //текущее время минус время начала выполнения алгоритма.

DateTime d2 = DateTime.Now; //проверка скорости работы алгоритма
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А (SumSimple): ",res1); //выводим результат 1
PrintData("Сумма чисел от 1 до А (SumGauss): ",res2); //выводим результат по Гауссу. он быстрее.