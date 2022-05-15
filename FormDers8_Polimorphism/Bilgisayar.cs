using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers8_Polimorphism
{
    public class Bilgisayar : URUN
    {
        public string BilgTuru { get; set; }

        public string Bilgİslemci { get; set; }

        public int BilgRam { get; set; }

        public override double kdvuygula()
        {
            return Fiyat*1.40;
        }

        public Bilgisayar(string ad, double fiyat, string bilgturu, string bilgİslemci, int bilgram)
        {
            UrunAdi = ad;
            BilgTuru = bilgturu;
            Fiyat = fiyat;
            Bilgİslemci = bilgİslemci;
            BilgRam = bilgram;

    }
    }
  
}
