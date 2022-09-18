/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9 */


Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

int min = 0;
int max = 0;

if (number1 > number2){
    max = number1; 
    min = number2;
    Console.WriteLine("Max = " + max);
    Console.WriteLine("Min = " + min);
} else {
    max = number2; 
    min = number1;
    Console.WriteLine("Max = " + max);
    Console.WriteLine("Min = " + min);
};