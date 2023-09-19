// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

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
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        res+=arr[i]; //накапливает все элменты на нечётных позициях в переменную res
    }
    return res; //возвращаем значение переменной res
}

// //вспомогательный элемент проверки на чётность 
// bool Test(int n)
// {
//     return (n%2==0);
// }

int[] testArr = Gen1DArray(5,0,1000); //запускаем метод генерации массива
Print1DArr(testArr); //запускаем метод печати массива
int count = SumPos(testArr); //запускаем метод подсчёта элментов
PrintData("Cумма элементов, стоящих на нечётных позициях: "+count); //выводим (печатаем) результат


// // Вариант 2

// Console.Write($"Введи количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numberElements, 1, 10);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");


// //Вариант 3
// int size = 4;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int sumNumbersEvenIndex = 0;

// for (int i = 1; i < numbers.Length; i += 2)
// {
//     sumNumbersEvenIndex += numbers[i];
// }
// Console.Write(sumNumbersEvenIndex);



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

