//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел в массиве.


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


int CountNumber(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
return count;
}

int[] array = GetArray(8, 100, 1000);
Console.WriteLine(String.Join(", ", array));

int count = CountNumber(array);
Console.WriteLine($"Количество четных чисел в массиве {count}");