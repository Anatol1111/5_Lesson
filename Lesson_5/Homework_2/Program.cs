// Задача 2: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

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
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void unevenNum(int[] arr)
{
    int SumIndex = 0;
    for (int i = 0; i < arr.Length; i++)
        if(i % 2 != 1)
        SumIndex += arr[i];
    Console.WriteLine($"Сумма элементов на нечетных позициях {SumIndex} ");
}
int[] arr_1 = MassNums(4);
Print(arr_1);
unevenNum(arr_1);