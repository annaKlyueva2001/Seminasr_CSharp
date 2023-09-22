//Задача 1. Напишите программу, которая на вход принимает 
//число и выдает его квадрат

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine()); // считывает строку и переводит в числа
// Console.WriteLine($"Squad of {num} = " + (num * num) ); // $ перед строкой позволяет внедрять числовые значения внутрь строки



// Задача 2. Напишите программу, которая на вход принимает два числа и 
// проверяет, является ли первое число квадратом второго

// Console.WriteLine("Input number a: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Input number b: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
//
// if(num2 * num2 == num1)
// {
//    Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else
// {
//    Console.WriteLine($"{num1} не является квадратом {num2}");
// }




// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе
// показывает все целые числа в промежутке от -N до +N
//
// 2 -> '-2, -1, 0, 1, 2'

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
//
// int count = -n;
// while(count < n + 1)
// {
//     Console.Write(count++);
// }



// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает **последнюю** цифру этого числа
//
// 456 -> 6

// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
//
// if(num >= 100 && num <= 999)
// {
//     Console.WriteLine($"Last digit of {num} -> {num%10}");
// }
// else
// {
//     Console.WriteLine("You input not three-digit number");
// }