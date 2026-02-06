using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolaPojazdy4d
{
    internal class Samochod : Pojazd
    {

        private int liczbaDrzwi;

        public Samochod(string marka, ushort rokProdukcji, int liczbaDrzwi) : base ( marka, rokProdukcji) 
        {
            this.liczbaDrzwi = liczbaDrzwi;
        }
        public Samochod(Samochod auto) : base(auto.marka, auto.rokProdukcji)
        {
            this.liczbaDrzwi = auto.liczbaDrzwi;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            return 100.0 * dni;
        }
        public override string Opis()
        {
            return base.Opis() + $" liczba drzwi: {this.liczbaDrzwi}";
        }
    }
}
