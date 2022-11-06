string[] victoriaLine = new string[16] { "brixton", "stockwell", "vauxhall", "pimlico", "victoria", "green park", "oxford circus", "warran street", "euston", "king's cross", "highbury & islington", "finsbury park", "seven sisters", "tottenham hale", "blackhorse road", "walthamstow central" };


Console.Write("Station 1: ");
var station1 = Console.ReadLine();
Console.Write("Station 2: ");
var station2 = Console.ReadLine();

if (station1 != null && station2 != null)
{
    var station1low = station1.ToLower().ToString();
    var station2low = station2.ToLower().ToString();
    int index1 = Array.IndexOf(victoriaLine, station1low);
    int index2 = Array.IndexOf(victoriaLine, station2low);
    Console.WriteLine(station1 + " to " + station2 + " is " + (index2 - index1) + " stops");
}

