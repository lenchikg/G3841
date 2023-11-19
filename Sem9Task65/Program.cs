// Задача 65
// Задайте значения M и N. 
//Напишите программу, которая найдёт 
//все натуральные элементы в промежутке от M до N.

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

//метод возврата натуральных элементов от М до N
string RecLineMN(int m, int n)
{
    if (m >= n)//точка остановки
    {
        return n.ToString();
    }
    else
    {
        return m + " " + RecLineMN(m + 1, n); //рекурентный вызов
    }
}

// шаги:
// 1 - вызов
// string RecLineMN(10, 5)
// {
//     if (10 >= 5) //сравнивает 5 и 10
//     {
//         return 5.ToString();
//     }
//     else
//     {
//         return 5 + " " + 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 2 - вызов
// string RecLineMN(6, 10)
// {
//     if (6 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 3 - вызов
// string RecLineMN(7, 10)
// {
//     if (7 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 4 - вызов
// string RecLineMN(8, 10)
// {
//     if (8 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 8 + " " + 9 + " " + 10;
//     }
// }
// 5 - вызов
// string RecLineMN(9, 10)
// {
//     if (9 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 9 + " " + 10;
//     }
// }
// 6 - вызов
// string RecLineMN(10, 10)
// {
//     if (10 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {
//         return m + " " + RecLineMN(m + 1, n);
//     }
// }

int numM = ReadData("Введите число M: "); //просим ввести число
int numN = ReadData("Введите число N: "); //просим ввести число

//тип_данных имя_переменной = (условие, например numM<numN)? значение1:(иначе)значение2
string res = numM<numN? RecLineMN(numM,numN):RecLineMN(numN,numM); // тернарный оператор, меняем местами большое и маленькое число. вызываем рекурсию
PrintResult(res);//возвращаем результат