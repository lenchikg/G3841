// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

//метод поиска минимального элемента
(int x, int y) SearchMinElem(int[,] matr) //(int x, int y)-возвращаем два значения из метода
{
    int raw = 0;
    int col = 0;
    int minElem = int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++)//внешний цикл, ищем минимальное значение.
    {
        for (int j = 0; j < matr.GetLength(1); j++)//внутренний цикл, проходим по строчкам и ищем минимальное значение.
        {
            if (minElem > matr[i, j])
            {
                raw = i;
                col = j;
                minElem = matr[i, j];
            }
        }
    }
    return (raw, col);//возвращаем два значения из метода
}

//метод обновления массива.
int[,] Update2DArray(int[,] matr, int x, int y)
{
    int[,] resArr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];//родительская матрица

    int k = 0; //вспомогательные операторы
    int m = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        m = 0;//начинаем с нулевой колонки
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                resArr[k, m] = matr[i, j];//матрица потомок
            }
            if (j != y) //если мы не находимся на удаляемой колонке
            {
                m++; //то будем увеличивать
            }
        }
        if (i != x) //если мы находимся на удаляемой колонке, то не будем увеличивать
        {
            k++;
        }
    }
    return resArr;
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

(int x, int y) minElem = SearchMinElem(matrix); //вызываем метод SearchMinElem и передаём в него матрицу

int[,] newMatrix = Update2DArray(matrix, minElem.x, minElem.y); //генерим новую матрицу, в которой передали главную матрицу и элементы х и у
Print2DArray(newMatrix); //печатем новую матрицу