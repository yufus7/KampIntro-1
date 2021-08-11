using System;

namespace Day3Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager manager = new MusteriManager();
            
            Musteri m1 = new Musteri();
            m1.Id = 1;
            m1.Name = "Ali";
            m1.LastName = "Sela";

            manager.add(m1);
            manager.delete(m1);
            manager.update(m1);






        }
    }
}
