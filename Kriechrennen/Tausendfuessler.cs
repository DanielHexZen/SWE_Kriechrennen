namespace Kriechrennen;

// taussendfuessler schnell in kurzen Schüben (1-3), aber manchmal sehr weit (Zufall < 10%)
class Tausendfuessler : Kriechtier
{
    public Tausendfuessler(Random rand) : base(rand)
    {
        symbol = ">>>>>";
    }

    // 1-3 Schritte, mit 10% großer Sprung (8)
    public override void Krieche()
    {
        if (rand.Next(0, 10) == 0)
            ErhoheStrecke(8);
        else
            ErhoheStrecke(rand.Next(1, 4));
    }
}
