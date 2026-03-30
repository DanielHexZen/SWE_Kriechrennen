namespace Kriechrennen;

class Wurm : Kriechtier
{
    public Wurm(Random rand) : base(rand)
    {
        symbol = "~";
    }

    // Zufallszahl zwischen 0 und 6
    public override void Krieche()
    {
        ErhoheStrecke(rand.Next(0, 7));
    }
}
