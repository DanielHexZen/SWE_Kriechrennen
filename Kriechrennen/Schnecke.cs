namespace Kriechrennen;

class Schnecke : Kriechtier
{
    public Schnecke(Random rand) : base(rand)
    {
        symbol = "@";
    }

    // Zufallszahl zwischen 2 und 4
    public override void Krieche()
    {
        ErhoheStrecke(rand.Next(2, 5));
    }
}
