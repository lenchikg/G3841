// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8


Console.WriteLine("Введите 5 любых чисел и я определю среди них чётные"); //просим ввести числа

int[] numArray = new int[5];

for (int i = 0; i < numArray.Length; i++)
{
    Console.Write($"Введите {i}-е число и нажмите Enter: "); //просим ввести числа по очереди
    numArray[i] = int.Parse(Console.ReadLine());
}

Console.Write("Вы ввели такие числа: ");
for (int i = 0; i < numArray.Length; i++)
{
    Console.Write($"{numArray[i]} "); //показываем введённый массив
}

Console.WriteLine(); //Перенос строки.
Console.Write("Среди них чётные: "); //Показываем чётные числа

for (int i = 0; i < numArray.Length; i++)
{
        if (numArray[i] % 2 == 0)
        Console.Write($"{numArray[i]} ");
}

// string numArray = Console.ReadLine(); //просим ввести числа

// int n = int.Parse(numArray); //парсим введённые числа

// string result = string.Empty; //пока пустая

// for (int i = 2; i < n; i = i + 2)
// {
//     result = result + i + ",";
// }

// if (n % 2 == 0) //проверяем, делиться ли чило на 2 без остатка
// {
//    result = result + n;
// }

// Console.WriteLine("Введённое вами число " +  result + " Нечётное"); //число нечётное