// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 150);
    }
    return arr;
}

int InRange(int[] arr)
{   
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            n += 1;            
        }
    }
    return n;    
}


int[] arr_1 = MassNums(123);
Print(arr_1);
Console.WriteLine(InRange(arr_1));

int[] arr_2 = MassNums(123);
Print(arr_2);
Console.WriteLine(InRange(arr_2));
