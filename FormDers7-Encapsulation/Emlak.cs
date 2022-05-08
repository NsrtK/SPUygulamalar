using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers7_Encapsulation
{
    public class Emlak
    {
        public string semt;

        public string Semt { get { return semt; } set { semt = value.ToUpper(); } }

        public int odasayisi;

        public int Odasayisi { get { return odasayisi; } set { odasayisi = Math.Abs(value); } }

        public int katNo;

        public int KatNo { get { return katNo; } set { katNo = Math.Abs(value); } }

        public int alan;

        public int Alan { get { return alan; } set { alan = Math.Abs(value); } }
        




    }
}
