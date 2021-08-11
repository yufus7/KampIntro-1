using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Odev3
{
    class MusteriManager
    {

        public void add(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : "+musteri.Name);
        }
        public void delete(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.Name);
        }
        public void update(Musteri musteri)
        {
            Console.WriteLine("Musteri guncellendi : " + musteri.Name);
        }
    }
}
