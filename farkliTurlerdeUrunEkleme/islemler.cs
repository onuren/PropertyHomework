using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkliTurlerdeUrunEkleme
{
    class islemler
    {
        public elektronik[] elektronikDizi;
        public gida[] gidaDizi;
        public multimedia[] multimediaDizi;

        public islemler()
        {
            elektronikDizi = new elektronik[0];
            gidaDizi = new gida[0];
            multimediaDizi = new multimedia[0];
        }

        public void ekle(elektronik alinanDizi)
        {
            elektronik[] gecici = new elektronik[elektronikDizi.Length+1];
            Array.Copy(elektronikDizi, gecici, elektronikDizi.Length);
            gecici[gecici.Length - 1] = alinanDizi;
            elektronikDizi = gecici;
        }
        public void ekle(gida alinanDizi)
        {
            gida[] gecici = new gida[gidaDizi.Length + 1];
            Array.Copy(gidaDizi, gecici, gidaDizi.Length);
            gecici[gecici.Length - 1] = alinanDizi;
            gidaDizi = gecici;
        }
        public void ekle(multimedia alinanDizi)
        {
            multimedia[] gecici = new multimedia[multimediaDizi.Length + 1];
            Array.Copy(multimediaDizi, gecici, multimediaDizi.Length);
            gecici[gecici.Length - 1] = alinanDizi;
            multimediaDizi = gecici;
        }
        public void yazdir()
        {
            foreach (var item in elektronikDizi)
            {
                Console.WriteLine(item.marka+" \n"+item.fiyat+" TL");
            }
            foreach (var item in gidaDizi)
            {
                Console.WriteLine(item.marka + " \n" + item.fiyat + " TL");
            }
            foreach (var item in multimediaDizi)
            {
                Console.WriteLine(item.urunAdi + " \n" + item.fiyat + " TL");
            }
        }
    }
}
