string[] actions = new string[4] { "pick", "drop", "pull", "search" };
List<string> items = new List<string>();

while (true)
{
    Console.Write("Enter action (pick/drop/pull/search): ");
    var action = Console.ReadLine();

    if (action != null)
    {
        if (actions.Contains(action))
        {
            switch (action)
            {
                case "pick":

                    Console.Write("What item? ");
                    var item = Console.ReadLine();
                    if (item != null)
                    {
                        items.Add(item);
                        Console.WriteLine("Added item!");
                        
                    }
                    continue;

                case "drop":
                    if (items.Count > 0)
                    {
                        Console.Write("What item to drop? ");
                        var drop = Console.ReadLine();
                        if (drop != null)
                        {
                            if (items.Contains(drop))
                            {
                                items.Remove(drop);
                                Console.WriteLine("Removed item!");
                            }
                            else
                            {
                                Console.WriteLine("That item isn't in your inventory...");
                            }
                        }
                    }
                    
                    continue;

                case "pull":
                    if (items.Count > 0)
                    {
                        var Random = new Random();
                        int i = Random.Next(items.Count);
                        Console.WriteLine(items[i]);
                    }
                    
                    continue;

                case "search":
                    foreach(var j in items)
                    {
                        Console.WriteLine(j);
                    }
                    continue;
            }
        }
        else
        {
            Console.WriteLine("Please enter valid action");
        }
    }
    
}