// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateArray(int len, int min, int max)
{
    int[] list = new int[len];//Создаём массив
    Random rnd = new Random();//генератор случайных чисел
    for (int i = 0; i < list.Length; i++)//цикл для заполнения массива рандомным значением
    {
        list[i] = rnd.Next(min, max); //присваиваем значению рандомное число в диапазоне и подставляем это значение в массив по местоположению индекса

    }
    return list;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}


void FindOdd(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
            if (i % 2 != 0 )
            {
                sum += Array[i];
            }
     
    }
    Console.Write($"Сумма элементов, стоящих на нечётных позициях: {sum}");
    
}

int[] arr = GenerateArray(8, 0, 10);

PrintArray(arr);
Console.WriteLine();
FindOdd(arr);