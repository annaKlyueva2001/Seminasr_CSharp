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


int [] array = { 1, 21, 31, 4, 15, 16, 17, 18};
//array[0] = 12; //поменять значение внутри массива
//Console.WriteLine(array[4]); // вытащить число с индексом 0
int n = array[^1];
int find = 4;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
