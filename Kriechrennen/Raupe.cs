namespace Kriechrennen;

class Raupe : Kriechtier
{
    public Raupe(Random rand) : base(rand)
    {
        symbol = "ooo<";
    }

    // Bei Zufallszahl 1: Strecke um 4 erhöhen, sonst nichts
    public override void Krieche()
    {
        if (rand.Next(0, 2) == 1)
            ErhoheStrecke(4);
    }
}
