using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDers9_interface_enum
{
    public interface IUrunSatis
    {
        int UrunFiyat { get; set; }

        int Urunadet { get; set;}

        string MusteriAd { get; set; }

        string MusteriSoyad { get; set; }

        string bilgileriYaz();

    }
}
