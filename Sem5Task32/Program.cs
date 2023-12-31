﻿// Задача №32
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Вариант 1


//метод для генерации массива. универсальный.
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//метод для вывода результата. //метод печати массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

//метод инвертирования массива
void InvArr(int[] arr) //убедимся, что массив ссылочного типа (не примитивного типа - создаётся копия массива, а в ссылочном мы работаем с исходным объектом)
{
    for(int i=0;i<arr.Length;i++) //перебираем элменты массива
    {
        arr[i]*=-1; //меняем значение с положительного на отрицательное и наоборот
    }
}

//метод, который не меняет массив, а создаёт новый массив
int[] InvArrNew(int[] arr)
{
    int[] newArr = new int[arr.Length]; //создание нового массива внутри метода. длина из предыдущего
    for(int i=0;i<arr.Length;i++)
    {
       newArr[i] = arr[i]*-1; //инвертируем каждый элмент массива
    }
    return newArr;
}


int[] testArr = Gen1DArr(12,-9,9); //генерируем массив. вызываем метод
Print1DArr(testArr); //вызываем метод печати массива
InvArr(testArr); // вызываем метод инвертирования массива
int[] testArrNew = InvArrNew(testArr); //создаём новый массив
Print1DArr(testArr);//выводим новый массив

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
// int[] reverse1DArray(int[] array)
// {
//     int[] arr=array; //здесь мы в одну и ту же ячейку памяти обращаемся, а в первом варианте мы сделали в разных ячейках памяти
//     for (int i = 0; i < array.Length; i++)
//     {
//         arr[i]*=-1;
//     }
//     return arr;
// }
// int len = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// Console.WriteLine("Оригинал:");
// int[]arr=create1DArray(len,num1,num2);
// show1DArray(arr);
// Console.WriteLine("реверс:");
// int[]reverse_arr=reverse1DArray(arr);
// show1DArray(arr);