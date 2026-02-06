using KonsolaPojazdy4d;
using System.Collections.Generic;

List<Pojazd> lista = new List<Pojazd>();

Console.WriteLine("Napisz marke motocyklu");
string markaMotocykla = Console.ReadLine();
Console.WriteLine("Napisz rok produkcji motocyklu");
ushort rokProdukcjiMotocykl = ushort.Parse(Console.ReadLine());
Console.WriteLine("Napisz true lub false w zależności czy moytocykl jest zabytkowy");
bool czyZabytkowy = bool.Parse(Console.ReadLine());
lista.Add(new Motocykl(czyZabytkowy,markaMotocykla,rokProdukcjiMotocykl));

Console.WriteLine("Napisz marke samochodu");
string markaSamochodu = Console.ReadLine();
Console.WriteLine("Napisz rok produkcji samochodu");
ushort rokProdukcjiSampchodu = ushort.Parse(Console.ReadLine());
Console.WriteLine("Napisz ile drzwi ma samochod");
int iloscDrzwi = int.Parse(Console.ReadLine());
lista.Add(new Samochod(markaSamochodu, rokProdukcjiSampchodu, iloscDrzwi));

foreach (Pojazd item in lista)
{
    Console.WriteLine(item.Opis());
    Console.WriteLine(item.ObliczKosztWynajmu(5));
}