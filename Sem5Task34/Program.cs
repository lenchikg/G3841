// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

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

//метод подсчёта количества чётных элментов
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

//вспомогательный элемент проверки на чётность 
bool Test(int n)
{
    return (n%2==0);
}

int[] testArr = Gen1DArray(123,0,1000); //запускаем метод генерации массива
Print1DArr(testArr); //запускаем метод печати массива
int count = CountElem(testArr); //запускаем метод подсчёта элментов
PrintData("Количество чётных элементов: "+count); //выводим (печатаем) результат

// // Вариант 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);


// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     count++;
// }


// Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Вариант 3

// Console.Clear();
// int[] numbers = new int[10];

// void FillArray(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }

// void WriteArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int QuantityPositive(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }

// FillArray(numbers, 100, 1000);
// WriteArray(numbers);
// Console.WriteLine();

// int quantity = QuantityPositive(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");