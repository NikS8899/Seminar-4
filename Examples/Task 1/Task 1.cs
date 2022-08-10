// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int deg = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow (number, deg));
System.Console.WriteLine($"Результат: {result} ");

