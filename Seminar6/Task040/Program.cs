﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void Trigon(int A, int B, int C)
{
    if (A < B + C & B < A + C & C < A + B) Console.WriteLine("Треугольник");
    else Console.WriteLine("Нет");
}
Trigon(5, 15, 9);