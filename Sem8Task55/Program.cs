// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя: "Матрицу перевернуть нельзя!"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//метод транспонирования массива
void TransArray(int[,] matr)
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            k = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = k;
        }
    }
}

//создаём тестовый массив
bool TestArray(int[,] arr) //передаём массива
{
    if (arr.GetLength(0) == arr.GetLength(1)) //сравним, если у массива совпадают размеры, то мы можем его транспонировать
    {
        return true;
    }
    else
    {
        Console.WriteLine("Матрицу перевернуть нельзя!");
        return false;
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

if (TestArray(matrix)) //если тест проходим, то вызываем метод  TransArray
{
    TransArray(matrix);
    Print2DArray(matrix);
}