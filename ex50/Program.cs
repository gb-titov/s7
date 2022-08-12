// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


using ex50;
Console.WriteLine("Программа для вывода элемента массива по его координатам.");
double[,] array = new double[5, 10].SetArray(10);
array.WriteArrayToConsole();
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());



double? resNum = FindItemByIndex(array, row, column);

Console.WriteLine(resNum == null ? $"{row},{column} -> такого элемента нет" : $"{row},{column}-> {resNum:F2}");


double? FindItemByPosition(double[,] arr, int index)
{
    if (index > arr.Length - 1)
        return null;
    int tmp = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (tmp == index)
                return arr[i, j];
            tmp++;
        }
    }

    return null;
}

double? FindItemByIndex(double[,] arr, int row, int column)
{
    if (row > arr.GetLength(0) || column > arr.GetLength(1))
        return null;
    return arr[row-1, column-1];
    
}






