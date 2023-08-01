// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

Console.Write("Введите первое число: "); //просим ввести 1е число
int number1 = int.Parse(Console.ReadLine()); //парсим 1е число

Console.Write("Введите второе число: "); //просим ввести 2е число
int number2 = int.Parse(Console.ReadLine()); //парсим 2е число

Console.Write("Введите третье число: "); //просим ввести 3е число
int number3 = int.Parse(Console.ReadLine()); //парсим 3е число

if (number1 > number2 && number1 > number3) //сравниваем числа 1 и 2 и 1 и 3
{
    Console.WriteLine(number1 + " больше " + number2 + " и больше " + number3); //число 1 больше
}
else if (number2 > number1 && number2 > number3) //сравниваем числа 2 и 1 и 2 и 3
{
    Console.WriteLine(number2 + " больше " + number1 + " и больше " + number3); //число 2 больше
}
else
{
    Console.WriteLine(number3 + " больше " + number1 + " и больше " + number2); // если число 1 и число 2 не больше числа 3, значит число 3 больше
}


//нельзя вводить одинаковые числа, в задаче об этом не сказано.

//второй вариант с массивом.
// Console.WriteLine("Хотите я угадаю, какое из введённых вами трёх чисел наибольшее?"); //интерактив
// Console.Write("Введите первое число: "); //просим ввести 1е число
// int number1 = int.Parse(Console.ReadLine()); //парсим 1е число

// Console.Write("Введите второе число: "); //просим ввести 2е число
// int number2 = int.Parse(Console.ReadLine()); //парсим 2е число

// Console.Write("Введите третье число: "); //просим ввести 3е число
// int number3 = int.Parse(Console.ReadLine()); //парсим 3е число

// int[] i = { number1, number2, number3 }; //создаём массив из трёх чисел
// int maxValue = i.Max(); //функцией определяем максимальное, чтобы не перебирать ручками каждое число массива
// Console.WriteLine("Наибольшее число из трёх введённых вами: " + maxValue + " Прикольно, да?"); //выводим максимальное число.
