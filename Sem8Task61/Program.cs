// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника

//Вычисляем факториал
float Factor(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


//метод формирования треугольника Паскаля
//_ _ _ _ _ 1
//_ _ _ _  1 1
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)//печатем строки (подчёркивание)
    {

        for (int j = 0; j <= nRow - i; j++) //печатем пробелы между подчёркиваниями
        {
            Console.Write(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            // создаём пробелы между элементами треугольника
            Console.Write(" ");
            //формула вычисления элементов треугольника
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();//переходим на слудующую строчку
    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: "); //получаем количество строк
PrintPascalTriangle(countRow);//показываем треугольник