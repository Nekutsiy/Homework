﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2= Convert.ToInt32(Console.ReadLine());
bool Chto0 = num1 > num2;
bool Chto1 = num1 == num2;
bool Chto2 = num1 < num2;
 
    
            if (Chto0)
            {
                Console.WriteLine($"Число {num1} больше чем {num2}");
            }
            else if (Chto1)
            {
                Console.WriteLine($"Числа {num1} и {num2} равны");
            }
            else
            {
                Console.WriteLine($"Число {num2} больше чем {num1}");
            };
