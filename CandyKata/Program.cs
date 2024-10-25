using CandyKata;

var keepGoing = true;

do
{
    Console.WriteLine("Enter a list of integers separated by a comma representing the rankings");
    try
    {
        var rankingsString = Console.ReadLine().Split(',');
        var rankings = new int[rankingsString.Length];
        for(var i =0; i<rankingsString.Length; i++)
        {
            rankings[i] = (int.Parse(rankingsString[i]));
        }
        var candies = CandySoulCrusher.GiveCandy(rankings);
        Console.Write("[");
        foreach(var candy in candies)
        {
            Console.Write(candy + ", ");
        }
        Console.WriteLine("]");
        Console.WriteLine($"Total candy needed: {candies.Sum()}");
        keepGoing = false;
    }
    catch (Exception)
    {
        Console.WriteLine("They all need to be integers");
    }

} while (keepGoing);