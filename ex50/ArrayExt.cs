
namespace ex50
{
    public static class ArrayExt
    {
        public static int[,] SetArray(this int[,] array,int min, int max)
        {
            var rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(min, max + 1);
                }
            }
            return array;
        }

        public static double[,] SetArray(this double[,] array, int mnozh = 1)
        {
            var rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int znak = rnd.Next(0, 2) == 1 ? -1 : 1;
                    array[i, j] = rnd.NextDouble() * mnozh * znak;
                }
            }

            return array;
        }




        public static void WriteArrayToConsole(this double[,] array, int round = 2)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(Math.Round(array[i, j], 2) + " ");
                }

                Console.WriteLine();
            }
        }

        public static void WriteArrayToConsole(this double[] array, int round = 2)
        {
            Console.Write($"[{array[0]}");

            for (int i = 1; i < array.Length; i++)
            {
                Console.Write($", {Math.Round(array[i], round)}");
            }
            Console.WriteLine("]");
        }

        public static void WriteArrayToConsole(this int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
