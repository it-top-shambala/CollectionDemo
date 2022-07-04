namespace CollectionDemo.Array
{
    internal static class Program
    {
        private static void Main()
        {
            /*Console.Write("Введите размерность массива: ");
            var size = Convert.ToInt32(Console.ReadLine());*/
            var array = new int[] {4, 5, 8, 10};

            /*for (var i = 0; i < size; i++)
            {
                array[i] = (i + 1) * (i + 1);
            }*/
            
            PrintArray(array);
            
            System.Array.Reverse(array);
            PrintArray(array);
            
            System.Array.Fill(array, 9);
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            Console.Write($"{nameof(array)}: [ ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("]");
        }
    }
}