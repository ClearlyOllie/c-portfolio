class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("How many runs? ");
            int runs;
            runs = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many numbers? ");
            int nums;
            nums = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= runs; j++)
            {
                Console.WriteLine();
                for (int i = 1; i <= nums; i++)
                {
                    Random rnd = new Random();
                    int res = rnd.Next(1, 100);
                    Console.Write($"{res,10}");
                }
            }

            Console.WriteLine("\n");

        }
    }
}