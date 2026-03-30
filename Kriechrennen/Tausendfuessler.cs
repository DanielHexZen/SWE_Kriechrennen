namespace Kriechrennen;

// Eigenes Kriechtier: bewegt sich schnell in kurzen Schüben (1-3), aber manchmal sehr weit (Zufall < 10%)
class Tausendfuessler : Kriechtier
{
    public Tausendfuessler(Random rand) : base(rand)
    {
        symbol = ">>>>>";
    }

    // Normalerweise 1-3 Schritte, selten (10%) ein großer Sprung von 8
    public override void Krieche()
    {
        if (rand.Next(0, 10) == 0)
            ErhoheStrecke(8);
        else
            ErhoheStrecke(rand.Next(1, 4));
    }
}
