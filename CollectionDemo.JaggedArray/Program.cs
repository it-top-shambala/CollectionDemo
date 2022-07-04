namespace CollectionDemo.JaggedArray
{
    internal static class Program
    {
        private static void Main()
        {
            const int size = 5;
            var array = new int[size][];
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[i + 1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = i;
                }
            }
            
            PrintArray(array);
        }

        private static void PrintArray(int[][] array)
        {
            Console.WriteLine("{");
            foreach (var item in array)
            {
                Console.Write(" [ ");
                foreach (var element in item)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine("]");
            }
            Console.WriteLine("}");
        }
    }
}