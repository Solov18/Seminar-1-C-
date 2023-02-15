/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
 (делится ли оно на два без остатка). */

int number1, number2, number3;
Console.Write("Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out number1);
Console.Write("Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out number2);
Console.Write("Введите 3 число: ");
int.TryParse(Console.ReadLine()!, out number3);
int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
    Console.Write($"{max}"); 
