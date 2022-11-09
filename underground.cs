string[] victoriaLine = new string[16] { "brixton", "stockwell", "vauxhall", "pimlico", "victoria", "green park", "oxford circus", "warran street", "euston", "king's cross", "highbury & islington", "finsbury park", "seven sisters", "tottenham hale", "blackhorse road", "walthamstow central" };
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

Console.Write("Station 1: ");
var station1 = Console.ReadLine();
Console.Write("Station 2: ");
var station2 = Console.ReadLine();
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

if (station1 != null && station2 != null)
{
    var station1low = station1.ToLower().ToString();
    var station2low = station2.ToLower().ToString();
    int index1 = Array.IndexOf(victoriaLine, station1low);
    int index2 = Array.IndexOf(victoriaLine, station2low);
    Console.WriteLine(station1 + " to " + station2 + " is " + (index2 - index1) + " stops");
}
            Console.WriteLine("\n");

        }
    }
}
