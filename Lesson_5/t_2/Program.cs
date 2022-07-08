// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.


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
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void ChangeValue(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }    
}


int[] arr_1 = MassNums(12);
Print(arr_1);
ChangeValue(arr_1);
Print(arr_1);

int[] arr_2 = MassNums(12);
Print(arr_2);
ChangeValue(arr_2);
Print(arr_2);
