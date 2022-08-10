// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number > 0) 
{
    result += number % 10;
    number /= 10;
}
System.Console.WriteLine($"Результат сложения всех цифр в числе = {result}");