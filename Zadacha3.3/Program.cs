﻿// Напишите программу,которая принимает на вход (N) и выдает таблицу кубов чисел
// от 1 до N
// 3->1,8,27 (первых 3 чисел)
// 5->1,8,27,64,125  (первых 5 чисел)  

// ВАРИАНТ 1
// int Kub (int x)
// {
// int a = x*x*x;
// return a;
// }
// int a = Kub (5);        
// Console.WriteLine(a);

// Здесь я молодец! Наконец то что-то получилось!)

// Вариант 2  
// Console.WriteLine("Введите число для возведения в куб");//Почему-то он мне здесь 
// double B = double.Parse(Console.ReadLine());       // ничего не возводит.    
// double result = Math.Pow (B,3);                    //Чего не хватает?

    // Вариант 3
    int n = 5; 
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i);
        Console.Write(" ");
    }