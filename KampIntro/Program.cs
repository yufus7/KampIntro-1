using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 50;
            int result = Sum(ref number1, number2);
            Console.WriteLine(number1);   //30
            Console.WriteLine(result);    //70



            Console.WriteLine("Hello World!");

            String[] diziler = { "ali", "kemal", "huseyin" };

            for(int i = 0; i < diziler.Length; i++)
            {
                Console.WriteLine(diziler[i]);
            }
            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.Egitmen="Ali";
            kurs2.Egitmen = "Kemal";
            kurs3.Egitmen = "Huseyin";


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
            }

        }
        static int Sum(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }
}
