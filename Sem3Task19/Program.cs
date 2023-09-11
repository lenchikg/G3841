// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов


// bool PalinTest(int n)
// {
//     bool res = false;
//     int d1 = n / 10000;
//     int d2 = (n / 1000) % 10;
//     int d3 = (n / 10) % 10;
//     int d4 = n % 10;
//     res = (d1 == d4) && (d2 == d3) ? true : false;
//     return res;
// }


Console.Write("Введите 5ти значное число, а я скажу, оно палидром или нет: ");
string? number = Console.ReadLine();

void PalinTest(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  PalinTest(number);
}
else Console.WriteLine($"Введите пожалуйста правильное 5ти значное число");