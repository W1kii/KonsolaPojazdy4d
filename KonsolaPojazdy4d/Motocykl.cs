using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolaPojazdy4d
{
    internal class Motocykl : Pojazd
    {

        private bool czyZabytkowy;
        public Motocykl(bool czyZabytkowy, string marka, ushort rokProdukcji):base(marka, rokProdukcji)
        {
            this.czyZabytkowy = czyZabytkowy;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            double kosztWynajmu = 70.0 * dni;
            if (czyZabytkowy == true) 
            {
                return kosztWynajmu * 1.2;
            }
            return kosztWynajmu;
        }

        public override string Opis()
        {
            if (czyZabytkowy == true)
            {
                return base.Opis() + ", motocykl jest zabytkowy";
            }
            return base.Opis() + ", motocykl nie jest zabytkowy";
        }
    }
}
