// Знакомство с функциями и массивами


// int a1 = .., b1 = ...
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

// int Max(int arg1, int arg2, int arg3)
//{
//    int result = arg1;
//    if(arg2 > result) result = arg2;
//    if(arg3 > result) result = arg3;
//    return result;
//}
//Console.WriteLine(max);


//int [] array = { 1, 21, 31, 4, 18, 15, 16, 17, 18};
//array[0] = 12; //поменять значение внутри массива
//Console.WriteLine(array[4]); // вытащить число с индексом 0
//int n = array.Length;
//int find = 18;
//int index = 0;
//while(index < n)
//{
//    if(array[index] == find)
//    {
//        Console.WriteLine(index);
//        break;  //выходи из цикла как только нашел
//    }
//    index++;
//}



// Функция и метод одно и то же

void FillArray(int[] collection)  //метод, который использует переменную-массив collection
{
    int length = collection.Length;
    int index = 0;
    while ( index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)  // void используется, если переменную не надо возвращать в программу
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while ( index < count )
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos); 