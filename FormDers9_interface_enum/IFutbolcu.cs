using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers9_interface_enum
{
    public interface IFutbolcu
    {
        string FutbolcuAdı { get; set; }
        string FutbolcuSoyadı { get; set; }

        int FutbolcuUcreti { get; set; }

        int SozlesmeYılı { get; set; }


        public string FutToplUct();
        

    }
}
