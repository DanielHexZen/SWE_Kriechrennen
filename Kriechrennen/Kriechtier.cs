namespace Kriechrennen;

abstract class Kriechtier
{
    private int strecke;
    protected Random rand;
    protected string symbol = "";

    public Kriechtier(Random rand)
    {
        this.rand = rand;
        this.strecke = 0;
    }

    public int Strecke => strecke;

    // Visualisierung: Unterstriche für zurückgelegte Strecke + Symbol
    public string Visualisierung => new string('_', strecke) + symbol;

    protected void ErhoheStrecke(int wert)
    {
        strecke += wert;
    }

    public abstract void Krieche();
}
