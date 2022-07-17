//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 100;
int number2 = number / 10 % 10;
int number3 = number % 10;
int result = number1*10 + number3;
Console.WriteLine($"Решение задачи={result}");