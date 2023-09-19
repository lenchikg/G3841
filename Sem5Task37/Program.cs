// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Вариант 1

// метод для генерации массива. универсальный.
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// метод для вывода (печати) массива.
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// метод конвертации массива, умножает первые и последние числа массива, всех, по парам
int[] ConvertArr(int[] arr) //берёт начальный массив
{
    int[] resArr = new int[(arr.Length/2)+1]; //новый массив, уккзываем длину массива
    for (int i = 0; i < resArr.Length; i++) //проходим по новому массиву
    {
        resArr[i]=arr[i]*arr[arr.Length-1-i]; //обращаемся к первому и последнему массива и умножаем их. заполняем элементами первого массива
    }
    return resArr; //возвращаем новый массив в другой ячейке памяти.
}

int[] testArr = Gen1DArray(123,0,1000); //запускаем метод генерации массива
Print1DArr(testArr); //запускаем метод печати нового массива
int[] convArr = ConvertArr(testArr); //запускаем метод конвертации массива
Print1DArr(convArr); // запусаем метод  печати конвертирумого масива
Print1DArr(testArr); //ещё раз печатаем первый массив для сравнения


// // Вариант 2

// void show1DArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// double[] convert1DArray(double[] nums)
// {
//     double[] arr1={};
//     for (int i = 0; i < nums.Length/2; i++)
//     {
//         arr1=arr1.Append(nums[i] * nums[nums.Length - 1 - i]).ToArray();
//     }
//     if (Convert.ToDouble(nums.Length)/2!=Convert.ToDouble(nums.Length/2))
//     {
//          arr1=arr1.Append(Math.Pow(nums[nums.Length/2],2)).ToArray();
//     }
//     return arr1;
// }
// double[] multiInputs(string msg)
// {
//     Console.Write(msg);
//     string n = Console.ReadLine() ?? "0";
//     string[] arr = n.Split(" ");
//     double[] vec = { };
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if ((arr[i] != ""))
//             vec = vec.Append(double.Parse(arr[i])).ToArray();
//     }
//     return vec;
// }
// show1DArray(convert1DArray(multiInputs("введите значения для массива в строку: ")));