// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

string editLine(string text)
{
string txt = text;
if (txt[txt.Length - 1] != ' ')
{
txt += " ";
}
return txt;
}
Random rnd = new Random();

// метод генерации массива случайными числами
int[] create1DArray(int len, int num1, int num2)
{
int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
// заполним массив минимальными и максимальными значениями
arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
}
return arr;
}
// метод печати массива
void show1DArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write(arr[i] + "\t");
}
Console.WriteLine(" ");
}
// void show1DArrayWithMessage(string msg, int[] arr)
// {
// Console.WriteLine(editLine(msg));
// for (int i = 0; i < arr.Length; i++)
// {
// Console.Write(arr[i] + "\t");
//




// Вариант 2


//просим ввести данные массива
// int len = ReadData("Введите длинну массива: ");
// int minValue = ReadData("Введите минимальное значение индекса массива: ");
// int maxValue = ReadData("Введите максимальное значение индекса массива: ");
// int[] arr = Gen1DArray(len, minValue, maxValue);
// Print1DArr(arr);

// //метод ввода кода элмента, который нужно найти
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // //метод вывода результата
// // void PrintData(string res)
// // {
// //     Console.WriteLine(res);
// // }

// //метод для генерации массива. универсальный.
// int[] Gen1DArray(int len, int minValue, int maxValue)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// //метод для вывода (печати) массива.
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// //метод подсчёта количества чётных элментов
// int ReversArr(int[] arr)
// {
//     int temp;
//     int len = arr.Length; //вычисляем длину массива, 
//     for (int i = 1; i < arr.Length; i++)
//     {
//         res+=arr[i]; //накапливает все элменты на нечётных позициях в переменную res
//     }
//     return res; //возвращаем значение переменной res
// }






// Тест. чёт не заработало.

// // метод считающий сумму чисел
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 преобразовывает введёное число в целое число. Тоже самое что и IntParse.
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// // int sum = num1 + num2;
// // Console.WriteLine(sum);

// //void //тип функции который что-то возвращает, но ничего не делает. самая простая функция.
// void Summa(int num1, int num2)
// {
//     int sum = num1 + num2;
//     Console.WriteLine(sum);
// }

// //второй вид функции, который что-то вовзращает.

// int Summa2(int num1, int num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }

// // Console.WriteLine("Введите первое число");
// // int num1 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите второе число");
// // int num2 = Convert.ToInt32(Console.ReadLine());
// // Summa(num1,num2);

// // Console.WriteLine(Summa2(num1,num2) * 10 );

// // int sum = num1 + num2;
// // Console.WriteLine(sum);

// // void Summa(int num1, int num2)
// // {
// // int sum = num1 + num2;
// // Console.WriteLine(sum);
// // }

// // int Summa2(int num1, int num2)
// // {
// // int sum = num1 + num2;
// // return sum;
// // }