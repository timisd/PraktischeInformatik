namespace Bruchrechnung
{
    public class Bruch
    {
        private int _nenner;
        public int Zaehler { get; private set; }

        public int Nenner
        {
            get => _nenner;
            private set
            {
                if (value == 0)
                    throw new ArgumentException("Der Nenner eines Bruchs darf nicht 0 sein!");

                _nenner = value;
            }
        }

        public Bruch(int zaehler, int nenner)
        {
            Zaehler = zaehler;
            Nenner = nenner;
        }

        public void SetzeZaehler(int zaehler)
        {
            Zaehler = zaehler;
        }

        public void SetzeNenner(int nenner)
        {
            Nenner = nenner;
        }

        public void Ausgeben()
        {
            Console.WriteLine($"Bruch: {Zaehler} / {Nenner}");
        }
    }
}