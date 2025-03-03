namespace ödev1acunmedya
{
    internal class Class1
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

