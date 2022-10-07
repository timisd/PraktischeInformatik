namespace Vorlesung3;

public class BankkontoGeaendertEventArgs : EventArgs
{
    public double NeuerKontostand { get; set; }
    public bool IstEinzahlung { get; set; }

    public BankkontoGeaendertEventArgs(double neuerKontostand, bool istEinzahlung)
    {
        NeuerKontostand = neuerKontostand;
        IstEinzahlung = istEinzahlung;
    }

    public override string ToString()
    {
        return IstEinzahlung
            ? $"Einzahlung! Neuer Kontostand {NeuerKontostand}"
            : $"Auszahlung! Neuer Kontostand {NeuerKontostand}";
    }
}