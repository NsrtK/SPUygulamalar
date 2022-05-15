using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers9_interface_enum
{
    public class Musteri : IUrunSatis
    {
        private int urunfiyat, urunadedi;
        private string musteriad, musteriSoyad, sonuc;



        public int UrunFiyat { get { return urunfiyat; } set {urunfiyat =value; } }
        public int Urunadet { get { return urunadedi; } set { urunadedi = value; } }
        public string MusteriAd { get{return musteriad;} set { musteriad = value; } }
        public string MusteriSoyad { get{return musteriSoyad;} set { musteriSoyad = value; } }

        public string bilgileriYaz()
        {
            sonuc = "Sayın " + musteriad + " " + musteriSoyad + " odeyeceğiniz tutar = " + (urunfiyat*urunadedi).ToString();


            return sonuc;
        }
    }
}
