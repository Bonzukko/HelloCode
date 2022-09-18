void FillArray (int[] collection) // ЭТОТ МЕТОД БУДЕТ ЗАПОЛНЯТЬ НАШ МАССИВ
// void - это метод, который ничего не возвращает. следовательно, в конце нельзя добавлять команду return. Мы дали ему название FillArray ( в переводе с англ. - заполнить массив). В качестве аргумента принимается какая-то коллекция(collection) - это всё произвольные названия
{
    int length = collection.Length; // получаем длину массива (присваиваем ей название length(длина)) с помощью специальной команды .Length - например collection.Length;
    int index = 0; 
    while (index < length) //  пока индекс меньше длины масива
    {
        collection [index] = new Random(). Next(1,10); // обращение к аргументу collection  на позицию index и положить туда новое случайное целое число из диапазона от 1 до 9
        index++;
    }
}
void PrintArray (int[] col) // это метод будет печатать массив. НЕ НАДО ДАВАТЬ АРГУМЕНТАМ ОДИНАКОВЫЕ ИМЕНА, поэтому здесь  имя не коллекшн, а кол
{
    int count = col.Length; // количество элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]); // выводим на экран значение текущей позиции
        position++;
    }
}

int [] array = new int[10]; // что дословно означает: создай новый массив, в котором будет 10 элементов

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // будет отражаться в консоли, если в массиве не будет искомого числа
    while (index < count)
    {
        if (collection [index] == find)
        {
         position = index;
         break;     // прерывает цикл после первого нахождения - без этой команды будет показывать последнюю позицию
        }
         index++;
    } 
    return position;
       
}
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 456);
Console.WriteLine(pos);