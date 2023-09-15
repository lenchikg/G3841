// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵) 2, 4 -> 16 
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

// Вариант 1
int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);

// // Вариант 2 - с ошибкой
// string str = TakeData("Введите выражение для расчета: "); // считываем выражение для расчета из консоли в строку
// string[] parts = str.Split('+', '-', '*', '/', '^'); // разбиваем полученную строку по знаку мат. действия и записываем их в массив parts


// Console.Write("Результат: " + Calculator(double.Parse(parts[0]), double.Parse(parts[1]), str[parts[0].Length]));
// /* выводим результат используя созданный метод. Символ действий над числами получаем из исходной строки, обратившись
//     к элементу под номерм "длина длина первого числа"*/


// string TakeData(string msg) //метод считывающий данные из консоли, выводя в неё сообщение
// { 
//     Console.Write(msg);
//     return Console.ReadLine() ?? "0";
// }

// double Calculator(double firstNum, double secNum, char operation)  // метод производящий указанное действие над двумя переданными числами
// {
//     switch (operation)
//     {
//         case '+': // если передали '+' то возвращаем сумму чисел
//             return firstNum + secNum;
//         case '-': // если передали '-' то возвращаем разность чисел
//             return firstNum - secNum;
//         case '*': // если передали '*' то возвращаем произведение чисел
//             return firstNum * secNum;
//         case '/': // если передали '/' то возвращаем частное чисел
//             return firstNum / secNum;
//         case '^': // если передали '^' то возвращаем возведение в степень
//             return Math.Pow(firstNum, secNum);
//         default: return 0; // если передали что-то еще, то возвращаем 0
//     }

// }


//Вариант 3 - не доделан

// //Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //Выводим результат пользователю
// void PrintData(string msg1, int msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

// //Метод, который возводит в степень
// int Pow(int numA, int numB)
// {
//     int res = 1;
//     while (numB > 0)
//     {
//         numB = numB - 1;
//         res = res * numA;
//     }
//     return res;
// }

// int numA = ReadData("Введите число A: ");  //сама программа. получим число от пользователя
// int numB = ReadData("Введите число B: ");  //сама программа. получим число от пользователя

// DateTime d1 = DateTime.Now; //проверка скорости работы алгоритма. фиксируем время начала.
// int res1 = Pow; //обращаемся к нашему методу
// Console.WriteLine(DateTime.Now - d1); //текущее время минус время начала выполнения 

// PrintData("Сумма чисел от 1 до А (SumSimple): ", Pow); //выводим результат