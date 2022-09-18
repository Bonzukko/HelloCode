            //  Написать программу, складывающую два числа (всё время уточняйте всю информацию - какие конкретно эти числа - целые или дробные; откуда эти два числа - вводит ли их пользователь или они генерируются случайным образом , или они уже даны; что делать с суммой?)

//  integer - целое число, numberA - название переменной
int numberA = new Random().Next(1, 10); //1,2,3,4...9
// 
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberA);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);