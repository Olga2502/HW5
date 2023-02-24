//: Задайте одномерный массив, заполненный  случайными числами. Найдите сумму элементов, стоящих на 
//нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

//int[] GetArray(int size, int minValue, int maxValue)
//{
//    int[] result = new int[size];
//
//    for (int i = 0; i < size; i++)
//    {
//        result[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return result;
//}


int Result(int[] inArray)
{
    int count = 0;
    for (int i = 1; i < inArray.Length; i = i + 2)
    {
        count += inArray[i];  
    }
    return count;
}

int[] array = GetArray(8, 2, 10);
Console.WriteLine(String.Join(", ", array));

int count = Result(array);
Console.WriteLine($"Cумма чисел стоящих на нечетной позиции в массиве {count}");
