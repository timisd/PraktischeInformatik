#define PREMIUM

using System.Drawing;
using Bruchrechnung;
using Console = Colorful.Console;

Console.WriteLine("Dies ist eine standard Ausgabe!");
#if PREMIUM
Console.WriteLine("Dies ist eine premium Ausgabe!", Color.Blue);
#endif

var bruch = new Bruch(187, 69);
Console.WriteLine("Bruchrechner Bibliothek");
bruch.Ausgeben();