﻿// Поиск максимума из 9 чисел - посредством функции(или правильнее для языка С# - метода)
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 14;
int c1 = 3500;
int a2 = 345;
int b2 = 23;
int c2 = 748;
int a3 = 31;
int b3 = 11;
int c3 = 9;

//  Ниже мы разделили всё на "три тройки игроков", нашли в каждой тройке максимальное число, далее сравнили три полученных числа и нашли максимальное из них и вывкли его
// int max1 = Max(a1, b1, c1);  
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); //  Мы не задаём новую переменную, мы внутри аргументы передаём функцию, работать будет так же, как и со строками 21-24 

Console.WriteLine(max);