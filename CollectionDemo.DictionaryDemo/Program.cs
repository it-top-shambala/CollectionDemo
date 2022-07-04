namespace CollectionDemo.DictionaryDemo
{
    internal static class Program
    {
        private static void Main()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("one", "один");
            dict.Add("two", "два");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            var keys = dict.Keys;
            foreach (var key in keys)
            {
                Console.Write($"{key} ");
            }
            Console.WriteLine();
            
            var values = dict.Values;
            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            dict["five"] = "пять";
            Console.WriteLine(dict["five"]);
        }
    }
}