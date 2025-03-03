using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1acunmedya
{
    public class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            bmw.marka = "BMW";
            bmw.Düz(bmw.marka);

            Porsche porsche = new Porsche();
            porsche.marka = "Porsche";
            porsche.Otomatik(porsche.marka);

            Togg togg = new Togg();
            togg.marka = "Togg";
            togg.Otomatik(togg.marka);

        }
    }
}
