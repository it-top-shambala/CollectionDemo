namespace CollectionDemo.Array2
{
    internal static class Program
    {
        private static void Main()
        {
            const int size = 5;
            var array = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }

            PrintArray(array);

            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
        }

        private static void PrintArray(int[,] array)
        {
            Console.WriteLine("{");
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                Console.Write("[ ");
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine("]");
            }
            Console.WriteLine("}");
        }
    }
}