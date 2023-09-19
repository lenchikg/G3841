// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

//Вариант 1


int posetivSum=0; //объявлем глобальную переменную для метода NegPosSum
int negotivSum=0; //объявлем глобальную переменную для метода NegPosSum

int[] testArr = Gen1DArr(12,-9,9); //вызываем метод, чтобы он работал
NegPosSum(testArr); //вызываем метод, чтобы он работал
Print1DArr(testArr); //напечатаем массив, чтобы понимать, как он выглядит
PrintData("Сумма положительных чисел в массиве: ", posetivSum); //выводим сумму положительных чисел
PrintData("Сумма отрицательных чисел в массиве: ", negotivSum); //выводим сумму отрицаельных чисел

//метод для вывода результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//метод для генерации массива. универсальный.
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random(); //создаём рандомное значение
    int[] arr = new int[len]; //создаём сам массив
    for (int i = 0; i < arr.Length; i++) //в цикле for проходим все элменты массива
    {
        arr[i] = new Random().Next(minValue, maxValue + 1); //заполняем минимальное и максимальное значение в массиве
    }
    return arr; //выдаём массив на выход
}

//метод печати массива
void Print1DArr(int[] arr)
{
    Console.Write("["); //печатаем ковычку
    for (int i = 0; i < arr.Length - 1; i++) //проходим все элементы кроме одного 
    {
        Console.Write(arr[i] + ", "); //ставим запятую после каждого значения
    }
    Console.WriteLine(arr[arr.Length - 1]+"]"); //печатаем последний элменты и ковычки.
}

//метод нахождения суммы отрицательных и положительных элементов массива.
void NegPosSum(int[] arr)
{
    for(int i=0;i<arr.Length;i++) //циклом проходим по массиву
    {
        if(arr[i]>0) //если элмент массива больше 0, 
        {
            posetivSum+=arr[i]; //то прибавляем к положительным
        }
        else
        {
            negotivSum+=arr[i]; //иначе привавляем к негативным (отрицательным)
        }

    }
}

// // Вариант 2 - не очень правильно, но работает
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int len = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// Random rnd = new Random();
// int[] createArray(int len)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// void showArray(int[] arr)
// {
//     for (int i = 0; i < len; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// int[]arr=createArray(len);
// showArray(arr);
// int Sum(int[] arr, bool MinOrMax){  //метод пишем с большой, переменную с маленькой
//     int sum=0;
//     foreach(var i in arr){
//         if ((MinOrMax==false)&&(i<0)){
//             sum+=i;
//         }
//         if ((MinOrMax==true)&&(i>0)){
//             sum+=i;
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Позитивные "+Sum(arr,true));
// Console.WriteLine("Негативные "+Sum(arr,false));