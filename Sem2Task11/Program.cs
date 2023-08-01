// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Вариант 1
System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(100, 1000);
Console.WriteLine("Случайное число: " + rndNum);

int digit1 = rndNum / 100; //делаем из двухзначного числа однозначное. берём только первое.
int digit2 = rndNum % 10; //убираем второе число

Console.WriteLine(digit1*10 + digit2);

// Вариант 2 - не работает.ругается на метод Main
// System.Random random = new System.Random();

// int randomNumber = random.Next(100,1000);

// Console.WriteLine("Случайное число: " + randomNumber);

// string value = randomNumber.ToString();

// char[] numberArray = value.ToCharArray();

// Console.WriteLine(numberArray[0] + " " + numberArray[2]);