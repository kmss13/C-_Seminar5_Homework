// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int len)
{
    double[] list = new double[len];//Создаём массив
    Random rnd = new Random();//генератор случайных чисел
    for (int i = 0; i < list.Length; i++)//цикл для заполнения массива рандомным значением
    {
        list[i] = rnd.NextDouble(); //присваиваем значению рандомное число и подставляем это значение в массив по местоположению индекса

    }
    return list;
}


void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Math.Round(Array[i],2) + " ");
    }
}
void Finddifference(double[] Array)
{
    double min = Array[0];
    double max =Array[0];
    double difference = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) 
        {
            max = Array[i];
        }
        if (Array[i] < min)
        {
            min = Array[i];
        }
        difference = max - min;
    }
    Console.Write($"Разница между максимальным и минимальным элементом : {Math.Round(difference,2)}");
}




double[] arr = GenerateArray(5);
PrintArray(arr);
Console.WriteLine();
Finddifference(arr);
