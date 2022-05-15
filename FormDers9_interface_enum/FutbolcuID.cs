using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers9_interface_enum
{
    public class FutbolcuID : IFutbolcu
       


    {
        public string futblcuadi, futbolcusoyadi, Toplamucret;
        public int futbolcuucreti, futbolcuyili;

        
        // set bölümlerine dikkat
        public string FutbolcuAdı { get { return futblcuadi; }  set { futblcuadi= value.ToUpper(); }  }
        public string FutbolcuSoyadı { get { return futbolcusoyadi; }  set { futbolcusoyadi = value.ToUpper(); } }
        public int FutbolcuUcreti { get { return futbolcuucreti; } set { futbolcuucreti=  Math.Abs(value); } }
        public int SozlesmeYılı { get { return futbolcuyili; } set { futbolcuyili= Math.Abs(value); } }

              
        public string FutToplUct()
        {
            Toplamucret = "Futbolcumuz :" + FutbolcuAdı + " " + FutbolcuSoyadı + " toplam ücreti " + (FutbolcuUcreti * SozlesmeYılı) + " olarak heaplanmıştır.";

            return Toplamucret;
        }
    }
}
