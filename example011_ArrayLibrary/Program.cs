void FillArray (int[] collection) // void - это метод, который ничего не возвращает. следовательно, в конце нельзя добавлять команду return
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random(). Next(1,10); // обращение к аргументу collection  на позицию index и положить туда новое случайное целое число из диапазона от 1 до 10
        index++;
    }
}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[10]; // что дословно означает: создай новый массив, в котором будет 10 элементов

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection [index] == find)
        {
         position = index;
         break;     
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