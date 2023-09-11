// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, string msg2, string msg3)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
    Console.WriteLine(msg3);
}

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}

// Ввод данных
int num = ReadData("Введите N: ");

//Собираем первую строчку таблицы
string line1 = LineBuilder(num, 1);
//Собираем вторую строчку таблицы
string line2 = LineBuilder(num, 2);
//Собираем третью строчку таблицы
string line3 = LineBuilder(num, 3);

// Вывод данных
PrintData(line1, line2, line3);

// или так. вариант 2
// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);