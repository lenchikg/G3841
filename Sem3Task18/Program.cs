//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).



int qNum = ReadData("Введите номер четверти от 1 до 4"); //Просим ввести данные
PrintQuorterAnswer(qNum); //вызываем метод
//Console.WriteLine("Введите координату X"); // Вводим данные с консоли - лучше по другому, так быстрее
//int coordX = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа //преобразование ASCII. ??-нулсейфти, чтобы небыло пустых значений. Лучше сделать как метод. см. ниже

//Метод, который читает данные от пользователя. чтобы не заставлять вводить каждую точку отдельно. Метод с входными и выходными параметрами.
int ReadData(string msg)
{
    Console.WriteLine(msg); // Вводим данные с консоли
    return int.Parse(Console.ReadLine() ?? "0"); //возвращаем
}

//Метод определения допустимого диапазона координат точке по четверти
void PrintQuorterAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("X > 0, Y > 0");
        if (num == 2) Console.WriteLine("X > 0, Y < 0");
        if (num == 3) Console.WriteLine("X < 0, Y < 0");
        if (num == 4) Console.WriteLine("X < 0, Y > 0");
    }
        else Console.WriteLine("Вы ввели не номер четверти"); 
}
