
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

void CalculateEvenNum(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            count++;
        }
        Console.Write(Array[i] + " ");
        
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

int[] arr = GenerateArray(5, 100, 999);

CalculateEvenNum(arr);