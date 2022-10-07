using System.ComponentModel;

namespace Vorlesung3;

public delegate void KontostandGaendertHandler(object sender, BankkontoGeaendertEventArgs args);

internal class Bankkonto : INotifyPropertyChanged
{
    public event KontostandGaendertHandler? KontostandGaendert;
    public event PropertyChangedEventHandler? PropertyChanged;

    public double Kontostand => _kontostand;

    private double _kontostand;

    public Bankkonto(double kontostand)
    {
        _kontostand = kontostand;
    }

    public void Einzahlen(double betrag)
    {
        _kontostand += betrag;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kontostand"));
        KontostandGaendert?.Invoke(this, new BankkontoGeaendertEventArgs(_kontostand, true));
    }

    public void Abbuchen(double betrag)
    {
        if (betrag > _kontostand)
            throw new Exception("Zu wenig Geld auf dem Konto!");

        _kontostand -= betrag;
        KontostandGaendert?.Invoke(this, new BankkontoGeaendertEventArgs(_kontostand, false));
    }
}