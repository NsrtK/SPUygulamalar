using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers8_Polimorphism
{
    public class Ekmek : URUN
    {
        public string EkmekTuru { get; set; }

        public int Gramaj {get; set;}

        public override double kdvuygula()
        {
            return Fiyat * 1.01;

        }

        public Ekmek (string ekmekTuru, int gramaj , string ad, double fiyat)
        {
            EkmekTuru = ekmekTuru;
            Gramaj = gramaj;

            UrunAdi = ad;
            Fiyat = fiyat;

        }

    }
}
