﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//
//if(num1 > num2)
//{
//    Console.WriteLine($"{num1} больше {num2}");
//}
//else
//{
//    if(num1 == num2)
//    {
//        Console.WriteLine($"{num1} равно {num2}");
//    }
//    else
//    {
//        Console.WriteLine($"{num1} меньше {num2}");
//    }
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.WriteLine("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input third number: ");
//int num3 = Convert.ToInt32(Console.ReadLine());
//
//int max = num1;
//if(max < num2)
//{
//    max = num2;
//}
//if(max < num3)
//{
//    max = num3;
//}
//Console.WriteLine($"Maximum number is {max}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

//Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num%2 == 0)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if(i%2 == 0)
    {
        Console.WriteLine(i);
    }
}