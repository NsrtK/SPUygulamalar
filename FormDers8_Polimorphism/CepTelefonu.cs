using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers8_Polimorphism
{
    public class CepTelefonu : URUN
    {
        public string Ozellikler { get; set; }
        public string Markası { get; set; }

        public CepTelefonu( string marka,string ad, double fiyat )
        {
            
            Markası = marka;

            UrunAdi = ad;
            Fiyat = fiyat;

        }
    }
}
