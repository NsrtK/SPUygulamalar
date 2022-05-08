using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers7_Encapsulation
{
    public class nothesap
    {
        public string adsoyad;

        public string AdSoyad { get{ return adsoyad; } set { adsoyad= value.ToUpper(); } }

        public string ders;

        public string Ders { get{ return ders; } set { ders= value.ToUpper(); } }

        public double not1;
        public double Not1 { get{ return not1; } set { not1 = Math.Abs(value); } }

        public double not2;
        public double Not2 { get { return not2; } set { not2 = Math.Abs(value);} }

        public double ort;
        public double Ort { get{ return ort= (not1 + not2) / 2; }  }


    }
}
