string[] notes = new string[10];

while (true)
{

    for (int i = 0; i < notes.Length; i++)
    {
        Console.WriteLine(i + ":" + notes[i]);
    }

    Console.Write("Enter note number: ");
    int num = System.Convert.ToInt32(Console.ReadLine());
    if (num <= 9 & num >= 0)
    {
        Console.Write("Enter note: ");
        var note = Console.ReadLine();
        if (note != null)
        {
            notes[num] = note.ToString();
        }
    }
    else
    {
        Console.WriteLine("Enter a number between 0 and 9");
    }
    


}