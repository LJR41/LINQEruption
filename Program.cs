// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

Eruption ChileEruption = eruptions.Where(e => e.Location == "Chile").OrderBy(e => e.Year).First();
Console.WriteLine(ChileEruption.ToString());

//----------------------------------------------------------------------------------------------------

Eruption? HawaiianIs = eruptions.FirstOrDefault(e => e.Location.Contains("Hawaiian Is"));
if(HawaiianIs == null)
{
    Console.WriteLine($"There is no Hawaiian eruption");
}
else{
    Console.WriteLine(HawaiianIs);
}

//----------------------------------------------------------------------------------------------------


Eruption? Greenland = eruptions.FirstOrDefault(e => e.Location.Contains("Greenland"));
if(Greenland == null)
{
    Console.WriteLine($"There is no Greenland eruption");
}
else{
    Console.WriteLine(Greenland);
}

//----------------------------------------------------------------------------------------------------

Eruption? FirstNZ = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");
Console.WriteLine(FirstNZ);

//----------------------------------------------------------------------------------------------------

IEnumerable<Eruption> OverTwoThousand = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(OverTwoThousand);

//----------------------------------------------------------------------------------------------------

IEnumerable<Eruption> StartsWithL = eruptions.Where(e => e.Volcano[0] == 'L');
PrintEach(StartsWithL);
Console.WriteLine(StartsWithL.Count());

//----------------------------------------------------------------------------------------------------

int Tallest = eruptions.Max(e=>e.ElevationInMeters);
Console.WriteLine(Tallest);

//----------------------------------------------------------------------------------------------------

Console.WriteLine(eruptions.Where(e => e.ElevationInMeters == Tallest).ToList()[0].Volcano);
string TallestVolcano2 = eruptions.FirstOrDefault(e => e.ElevationInMeters == Tallest).Volcano;
string TallestVolcano = eruptions.Where(e => e.ElevationInMeters == Tallest).Select(e => e.Volcano).ToList()[0];
Console.WriteLine(TallestVolcano);

//----------------------------------------------------------------------------------------------------

List<string> AlphaVolcano = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
AlphaVolcano.ForEach(Console.WriteLine);

//----------------------------------------------------------------------------------------------------

int TotalSum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(TotalSum);

//----------------------------------------------------------------------------------------------------

bool EruptedInTwoThousand = eruptions.Any( e => e.Year == 2000);
Console.WriteLine(EruptedInTwoThousand);

//----------------------------------------------------------------------------------------------------

List<Eruption> Stratos = eruptions.Where( e => e.Type == "Stratovolcano").Take(3).ToList();
Stratos.ForEach(Console.WriteLine);

//----------------------------------------------------------------------------------------------------

List<Eruption> BeforeOneThousand = eruptions.Where(e => e.Year < 1000).OrderBy(e =>e.Volcano).ToList();
BeforeOneThousand.ForEach(Console.WriteLine);

//----------------------------------------------------------------------------------------------------

List<string> BeforeOneThousandNames = eruptions.Where(e => e.Year < 1000).OrderBy(e =>e.Volcano).Select(e => e.Volcano).ToList();
BeforeOneThousandNames.ForEach(Console.WriteLine);


// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{

    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }

}



