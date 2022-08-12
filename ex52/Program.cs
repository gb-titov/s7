//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using ex52;

int[,] array = new int[5, 6].SetArray(0, 9);
array.WriteArrayToConsole();

double[] avgArr = GetAvgInColumns(array);
Console.Write("Среднее арифметическое каждого столбца: ");
avgArr.WriteArrayToConsole();




double[] GetAvgInColumns(int[,] arr)
{
    int rowLength = arr.GetLength(0);
    int columnLength = arr.GetLength(1);
    var avg = new double[columnLength];

    for (int i = 0; i < columnLength; i++)
    {
        double sum = 0;
        for (int j = 0; j < rowLength; j++)
        {
            sum += arr[j,i];
        }

        avg[i] = sum / (double)rowLength;
    }

    return avg;
}









