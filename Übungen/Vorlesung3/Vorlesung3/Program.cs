namespace Vorlesung3;

internal static class Program
{
    public static void Main()
    {
        // Calculator.Run();
        RunBankkonto();
    }

    #region Bankkonto

    private static void MeldungUeberGeaendertenKontostand(object sender, BankkontoGeaendertEventArgs args)
    {
        Console.WriteLine($"{sender.GetHashCode()} {args}");
    }

    private static void RunBankkonto()
    {
        var k1 = new Bankkonto(0);
        k1.KontostandGaendert += MeldungUeberGeaendertenKontostand;

        var k2 = new Bankkonto(0);
        k2.KontostandGaendert += MeldungUeberGeaendertenKontostand;

        k1.Einzahlen(123.45);
        k1.Abbuchen(19.99);

        k2.Einzahlen(500);
        k2.Abbuchen(125);
    }

    #endregion
}