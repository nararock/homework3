﻿// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int c = 0;
while(c < number){
    c++;
    Console.Write(Math.Pow(c, 3) + " ");
}
