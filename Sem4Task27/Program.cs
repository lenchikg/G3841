// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12 
// * Сделать оценку времени алгоритма через вещественные числа и строки

// Вариант 1
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumSym(int num)
{
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    return result;
}

int sumNumber = SumSym(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// // Вариант 2

// using System.Diagnostics; // подключаем библиотеку для подсчета времени выполнения операций

// string str = TakeData("Введите число: "); // получаем число из консоли
// Stopwatch stopwatch = new Stopwatch(); // инициализируем таймер для замера времени выполнения кода
// Console.WriteLine("\n\rСтроковый метод:"); // выводим информациию о текущем методе

// stopwatch.Start(); // запускаем таймер
// Console.WriteLine("Сумма цифр числа = " + SummNumByString(str)); // считаем сумму и выводим результат

// stopwatch.Stop(); // останавливаем таймер
// TimeSpan timeString = stopwatch.Elapsed; // запоминаем время выполнения для дальнейшего анализа
// Console.WriteLine("Затраченное время на подсчет суммы через строку:" + stopwatch.Elapsed); // выводим информацию о времени

// Console.WriteLine("\n\rЧисленный метод:"); // выводим информацию в консоль о начале численного метода
// stopwatch.Reset(); // обнуляем таймер
// stopwatch.Start(); // запускаем таймер
// Console.WriteLine("Сумма цифр числа = " + SummNumByNum(str)); // считаем сумму и выводим результат

// stopwatch.Stop(); // останавливаем таймер
// TimeSpan timeNum = stopwatch.Elapsed; // запоминаем время для дальнейшего анализа
// Console.WriteLine("Затраченное время на подсчет суммы численным методом:" + stopwatch.Elapsed); // выводим информацию о затраченном времени

// // анализируем результат замера, сравнивая полученные времена и выводи соответствующую информацию:
// if (timeString > timeNum) Console.WriteLine("\n\rСтроковый метод выполнялся дольше числинного на: " + (timeString - timeNum));
// else Console.WriteLine("\n\rЧисленный метод выполнялся дольше строкового на: " + (timeNum - timeString));



// string TakeData(string msg)  //метод считывающий данные из консоли, выводя в неё сообщение
// {
//     Console.Write(msg);
//     return Console.ReadLine() ?? "0";
// }

// double SummNumByString(string num) // метод считающий сумму цифр в числе используя строку
// {
//     int i = 0; // переменная-счетчик
//     double sum = 0; // переменая для накопления суммы

//     while (i < str.Length)
//     { // цикл пока не дойдем до послоеднего символа
//         sum = sum + char.GetNumericValue(str[i]); // прибавляем к сумме очередную цифру числа 
//         i++; // увеличиваем счетчик
//     }
//     return sum; // возвращаем результат
// }

// int SummNumByNum(string num) // метод считающий сумму цифр в числе численным методом
// {
//     int number = int.Parse(num); // преобразовывваем строку, полученную из кнсоли в число
//     int sum = 0; // переменная для накопления результата

//     while (number > 0)
//     { // цикл пока число > 0
//         sum = sum + number % 10;    // прибавляем к сумме остаток от целочисленного деления на 10    
//         number = number / 10; // делим число на 10
//     }
//     return sum; // возвращаем сумму
// }

//Вариант 3 - с ошибкой

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumSym(int num)
// {
//     int res = 0;

//     while (num > 0)
//     {
//         res = num + num % 10;
//         num = num / 10;
//     }
//     return res;
// }

// int sumNumber = SumSym(num);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);