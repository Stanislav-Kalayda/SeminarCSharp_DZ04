// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("введите число A");
// double num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число B");
// double num2 = Convert.ToInt32(Console.ReadLine());

// double Numbers()
// {
//     double work=1;
//     double count=1;

//     while (count<=num2)
//     {
//         work= work*num;
//         count=count+1;
//     }

//     return work;
// }
// double result=Numbers();
// Console.WriteLine(result);

// ----------------------------------------------------------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
//     int numbers = i % 10;
//     i = i / 10;
//     sum = sum + numbers;
// }
// Console.Write(sum);

// ------------------------------------------------------------------------------------------------------------------

// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 11);
//     Console.Write(" " + Array (i) + " ");
//  }
// Console.Write("]");

// int Array (int a)
// {
//     return numbers[a];
// }

// ------------------------------------------------------------------------------------------------------------------