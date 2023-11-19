// Задача 69
// Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии
// сравните два способа

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

//рекурентный метод, который умножает поочерёдно. последновательно. это медленный способ.
long RecPowFlow(int a, int b)
{
    if(b<=1)return a; //точка остановки
    return a*RecPowFlow(a,b-1); //рекурентный вызов
}

//рекурентный метод. хитрый. для сравнения. делением на 2. И он быстрее.
long MyPow(int a, int b)
{
    if(b==2)return a*a; //точка остановки, когда остаётся два значения.
    return MyPow(a,b/2)*MyPow(a,b/2); //рекурентный вызов только половинки.
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

long res1 =0;
long res2 =0;

DateTime d1 = DateTime.Now;
res1 = RecPowFlow(numberA,numberB);
PrintResult("Решение RecPowFlow: " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
res2 = MyPow(numberA,numberB);
PrintResult("Решение MyPow: " + (DateTime.Now - d2));


// если степень не делится на 2 без остатка, получается не верный результат!!!
// Надо добавить проверку b%2 == 1
// И если остаток есть, не просто рекурсию на рекурсию умножить, а еще добавить умножение на а.
// У меня это выгдялит так:

// long AvStepenBHitriy (int a, int b){
//     if(b<1) return 1;
//     if(b==1) return a;
//     if(b==2) return a*a;
//     if(b%2 == 1) return AvStepenBHitriy(a, b/2)*AvStepenBHitriy(a, b/2)*a;
//     else  return AvStepenBHitriy(a, b/2)*AvStepenBHitriy(a, b/2);
// }