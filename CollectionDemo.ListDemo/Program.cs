namespace CollectionDemo.ListDemo
{
    internal static class Program
    {
        private static void Main()
        {
            var list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            
            list[0] = 67890;
            Console.WriteLine(list[0]);
        }
    }
}