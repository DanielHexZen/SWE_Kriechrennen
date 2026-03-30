using Kriechrennen;

Random rand = new Random();

// Array mit allen Kriechtierarten
Kriechtier[] tiere = new Kriechtier[4]
{
    new Schnecke(rand),
    new Wurm(rand),
    new Raupe(rand),
    new Tausendfuessler(rand)
};

// Rennen-Schleife
bool zielErreicht = false;
while (!zielErreicht)
{
    Console.CursorTop = 0;

    foreach (Kriechtier tier in tiere)
    {
        tier.Krieche();
        Console.WriteLine(tier.Visualisierung.PadRight(80));

        if (tier.Strecke >= 50)
            zielErreicht = true;
    }

    Thread.Sleep(500);
}
