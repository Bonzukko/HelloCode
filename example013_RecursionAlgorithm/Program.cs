﻿                                                // ДВУМЕРНЫЕ МАССИВЫ И РЕКУРСИЯ

                            // Двумерные массивы

// string[,] table= new string [2,5]; // где 2 - количество строк, а 5 -столбцов
// table [1,2] = "word";   // table - наименование массива, 1 - индекс строки, 5 - индекс столбца
// // индексы для строк и столбцов указываются по тем же правилам - начинаются с 0

// // для заполнения этой таблицы нужно использовать цикл в цикле
// for(int rows = 0; rows < 2; rows++) //задаёт параметры для строк
// {
//     for(int columns = 0; columns < 5; columns++) // задает параметры для столбцов
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }

 
// void PrintArray (int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++) 
//     {
//       for(int j = 0; j < matr.GetLength(1); j++) 
//       {
//          Console.Write($"{matr[i,j]} ");
//       }
//       Console.WriteLine();
//     }
// }
// void FillArray (int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++) //  matr.GetLength(0) - эта команда возвращает количество строк в таблице
//     {
//       for(int j = 0; j < matr.GetLength(1); j++) //  matr.GetLength(1) - эта команда возвращает количество столбцов в таблице
//       {
//         matr[i,j] = new Random().Next(1,10);
//       }
//     }
// }
// int[,] matrix= new int [4,5];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


                      //Рекурсия - функция, которая вызывает сама себя

// Рекурсия на примере факториала (факториал = это произведение всех чисел от 1 до этого числа включительно)
// например, факториал (пишется, как 5!) 5! = 5 * 4 * 3 * 2 * 1
// 1! = 1
// 0! = 1

// double Factorial(int n)
// {
//   if(n==1) return 1;
//   else return n * Factorial(n-1);
// }
// for (int i = 1; i < 20; i++)
// {
//    Console.WriteLine($"{i}! = {Factorial(i)}");
// }


      // Рекурсия на примере последовательности Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci (int n)
{
  if (n == 1 || n ==2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
   Console.WriteLine($"{i}! = {Fibonacci(i)}");
}