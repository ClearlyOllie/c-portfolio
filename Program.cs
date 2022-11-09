class game
{
    static void Main(string[] args)
    {
        List<string> tanks = new List<string>();
        int[] choices = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
        int shells = 30;
        int score = 0;

        for (int i = 0; i < 10; i++)
        { 
            Random rand = new Random();
            string tankx = Convert.ToString(rand.Next(0, 8));
            string tanky = Convert.ToString(rand.Next(0, 8));
            string tankPos = tankx + tanky;

            if (tanks.Contains(tankPos))
            {
                i -= 1;
            }
            else
            {
                //Console.WriteLine(tankPos); //Writes the Position the tank is placed at
                tanks.Add(tankPos);
            }
        }
        
        while (shells > 0 && tanks.Count > 0)
        {
            Console.Write("Enter X coordinate: "); ;
            int xCor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            int yCor = Convert.ToInt32(Console.ReadLine());

            if (choices.Contains(xCor) && choices.Contains(yCor))
            {
                foreach (string tank in tanks)
                {
                    int tank1 = int.Parse(tank[0].ToString());
                    int tank2 = int.Parse(tank[1].ToString());

                    if (xCor == int.Parse(tank[0].ToString()) && yCor == int.Parse(tank[1].ToString()))
                    {
                        score += 1;
                        Console.WriteLine("That's a hit! Your score is {0}", score);
                        tanks.Remove(tank);
                        break;
                    }
                }
                shells -= 1;
            }
            else
            {
                Console.WriteLine("Please enter a number between 0 & 7 (including 0 & 7)");
            }
  
        }
        if (tanks.Count == 0)
        {
            Console.WriteLine("Congratulations on hitting all 10 tanks!");
        }
        else
        {
            Console.WriteLine("Better luck next time! Only {0} more tanks to go!", tanks.Count);
        }
    }
}
