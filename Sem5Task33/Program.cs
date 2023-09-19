// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Вариант 1

//метод ввода кода элмента, который нужно найти
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод для вывода (печати) результата.
void PrintData(string res)
{
    Console.WriteLine(res);
}

//метод для генерации массива. универсальный.
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//метод для вывода (печати) массива.
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод поиска в массиве
int Search(int[] arr, int e) //выдаем индекс найденнго числа. e - element
{
    int res = -1; //если -1 значит элемент не нашли
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == e)
        {
            res = i; //присваиваем значение итератору
            break; //остановка, если нашли результат. выходим из цикла for
        }
    }
    return res;
}

int[] testArr = Gen1DArray(12, -9, 9); //запускаем метод 
Print1DArr(testArr); //выводим результат, запускаем метод вывод
int element = ReadData("Какой элемент найти?: "); //получили от пользователя элмент. запустили метод
int result = Search(testArr, element); // выводим результат. 

if (result >= 0) //если результат больше или равно 0
{
    PrintData("Элемент найден в позиции: " + (result+1)); //выводим позицию, где найдено число
}
else
{
    PrintData("В массиве элемент не найден!"); //или не нашли
}

// // Вариант 2
// Random rnd = new Random();
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int[] create1DArray(int len, int num1, int num2)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// void show1DArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// int[] invert1DArray(int[] array)
// {
//     int[] arr=new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         arr[i]=array[i]*-1;
//     }
//     return arr;
// }
// int len = InputNum("Введите длинну массива: ");
// int x = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// int[]arr=create1DArray(len,num1,num2);
// int[] searchXIn1DArray(int x, int[] arr){
//     int[] indexs={};
//     for(int i=0; i<arr.Lengt