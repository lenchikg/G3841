// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// 1 2 3 4 5 ..... n
// n = 5

// num = 5   5_4_3_2_1_""
// num = 4     4_3_2_1_""
// num = 3       3_2_1_""
// num = 2         2_1_""
// num = 1           1_""
// num = 0            ""
//

//метод рекурентной функции. метод который вернёт нам строку. генератор строчки.
string LineGenRec(int num)
{
    if (num == 0)//точка остановки.
    {
        return string.Empty;
    }
    else
    {
        return num + " " + LineGenRec(num - 1); //идём слева на право. вызовет сам себя. -1 чтобы небыло переполнения стэка. от большего к меньшему от 5 до 1
        //return LineGenRec(num - 1) + " " + num ;//делает наоборот от 1 до 5
    }
}

int number = ReadData("Введите число N: "); //происим ввести число
string resultLine = LineGenRec(number); //вызываем рекурентый метод и вставляем туда число пользователя
PrintResult(resultLine);//показываем результат