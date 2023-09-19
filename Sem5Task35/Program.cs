// Задача №35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. (от 10 до 99)
// Например:
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Вариант 1

// //метод ввода кода элмента, который нужно найти
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

//метод вывода результата
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

//метод подсчёта количества элментов между 10 и 99
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i])) //из вспомогательного элмента Test
        {
            res++; //увеличение счётчика
        }
    }
    return res;
}

//вспомогательный элмент подсчёта количества элментов между 10 и 99. 
bool Test(int n)
{
    return (n>10&&n<99);
}

int[] testArr = Gen1DArray(123,0,1000); //запускаем метод генерации массива
Print1DArr(testArr); //запускаем метод печати массива
int count = CountElem(testArr); //запускаем метод подсчёта элментов
PrintData("Количество элементов в отрезке [10,99] :"+count); //выводим (печатаем) результат