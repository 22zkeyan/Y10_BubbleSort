namespace Y10_BubbleSort
{
    internal class Program
    {
        static void Starter()
        {
            int[] ages = { 12, 16, 14, 15 };
            int search_key = 16;
            foreach (int age in ages) 
            {
                if (age == search_key)
                {
                    Console.WriteLine($"Search key found at index {Array.IndexOf(ages, age)}");
                }
            }
        }
        static void Main(string[] args)
        {
            Starter();
        }
    }
}
