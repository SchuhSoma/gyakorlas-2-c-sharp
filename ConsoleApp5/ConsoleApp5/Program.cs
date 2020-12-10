using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int[] HoTMB = new int[31];
        static Random rnd = new Random();
        static int[] NapTMB = new int[14];
        static void Main(string[] args)
        {
            Homerseklet();
            MegtartottOrak();
            Console.ReadKey();
        }

        private static void MegtartottOrak()
        {
            Feladat1Meg(); Console.WriteLine("\n--------------------------\n");
            Feladat3Meg(); Console.WriteLine("\n--------------------------\n");
            Feladat4Meg(); Console.WriteLine("\n--------------------------\n");
            Feladat5Meg(); Console.WriteLine("\n--------------------------\n");
            Feladat6Meg(); Console.WriteLine("\n--------------------------\n");
            Feladat7Meg(); Console.WriteLine("\n--------------------------\n");
        }

        private static void Feladat7Meg()
        {
            Console.WriteLine("Írjuk ki az értékeket növekvő rendben!");
            int CsereNap;
            for (int i = 0; i < NapTMB.Length-1; i++)
            {
                for (int j = 0; j < NapTMB.Length-1; j++)
                {
                    if(NapTMB[j]>NapTMB[j+1])
                    {
                        CsereNap = NapTMB[j];
                        NapTMB[j] = NapTMB[j + 1];
                        NapTMB[j + 1] = CsereNap;
                    }
                }
            }
            for (int i = 0; i < NapTMB.Length; i++)
            {
                Console.Write("{0} , ", NapTMB[i]);
            }
        }

        private static void Feladat6Meg()
        {
            Console.WriteLine("Volt-e 6 órája valamikor?");
            int db6 = 0;
            for (int i = 0; i < NapTMB.Length; i++)
            {
                if(NapTMB[i]==6)
                {
                    db6++;
                }
            }
            if(db6>0)
            { Console.WriteLine("\tVolt 6 órája"); }
            else
            { Console.WriteLine("\tNem volt 6 órája"); }
        }

        private static void Feladat5Meg()
        {
            Console.WriteLine("Mennyi volt a legtöbb megtartott órája?");
            int MaxOra = int.MinValue;
            for (int i = 0; i < NapTMB.Length; i++)
            {
                if(MaxOra<NapTMB[i])
                {
                    MaxOra = NapTMB[i];
                }
            }
            Console.WriteLine("A legtöbb megtartott óra: {0}", MaxOra);
        }

        private static void Feladat4Meg()
        {
            Console.WriteLine("Hányszor tartott 1 órát?");
            int db = 0;
            for (int i = 0; i < NapTMB.Length; i++)
            {
                if(NapTMB[i]==1)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyiszer volt egy órája: {0}", db);
        }

        private static void Feladat3Meg()
        {
            Console.WriteLine("Adjuk meg, hogy mennyi pénzt keresett a tanár, ha nettó 2200 Ft-ot kap egy óráért!");
            int OsszesOra = 0;
            for (int i = 0; i < NapTMB.Length; i++)
            {
                OsszesOra += NapTMB[i];
            }
            Console.WriteLine("A tanár keresete ebben a két hétben : {0} Ft", OsszesOra*2200);
        }

        private static void Feladat1Meg()
        {
            Console.WriteLine("Töltsük fel a tömböt véletlenszámokkal a megadott tartományból");
            for (int i = 0; i < NapTMB.Length; i++)
            {
                NapTMB[i] = rnd.Next(1, 9);
            }
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine("Elemek kiiratása");
            for (int i = 0; i < NapTMB.Length; i++)
            {
                Console.WriteLine("\t{0,-3}. nap : {1,-2} óra", i+1, NapTMB[i]);
            }
        }

        private static void Homerseklet()
        {
            Feladat1Hom(); Console.WriteLine("\n--------------------------\n");
            Feladat3Hom(); Console.WriteLine("\n--------------------------\n");
            Feladat4Hom(); Console.WriteLine("\n--------------------------\n");
            Feladat56Hom(); Console.WriteLine("\n--------------------------\n");
            Feladat6Hom(); Console.WriteLine("\n--------------------------\n");
            Feladat7Hom(); Console.WriteLine("\n--------------------------\n");
        }

        private static void Feladat7Hom()
        {
            Console.WriteLine("Írjuk ki a hőmérséklet értékeket növekvő rendben");
            int CsereHomerseklet;
            for (int i = 0; i < HoTMB.Length-1; i++)
            {
                for (int j = 0; j < HoTMB.Length-1; j++)
                {
                    if(HoTMB[j]>HoTMB[j+1])
                    {
                        CsereHomerseklet = HoTMB[j];
                        HoTMB[j] = HoTMB[j + 1];
                        HoTMB[j + 1] = CsereHomerseklet;
                    }
                }
            }
            for (int i = 0; i < HoTMB.Length; i++)
            {
                Console.Write("{0} , ", HoTMB[i]);
            }
        }

        private static void Feladat6Hom()
        {
            Console.WriteLine("Volt-e +7 fok a hőmérséklet valamelyik napon?");
            bool Dontes = false;
            for (int i = 0; i < HoTMB.Length; i++)
            {
                if(HoTMB[i]==7)
                {
                    Dontes = true;
                }
            }
            if(Dontes==true)
            {
                Console.WriteLine("\tVolt ilyen");
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen");
            }
        }

        private static void Feladat56Hom()
        {
            Console.WriteLine("Mennyi volt a legalacsonyabb mért hőmérséklet?");
            int HoMin = int.MaxValue;
            int HoMax = int.MinValue;
            for (int i = 0; i < HoTMB.Length; i++)
            {
                if(HoTMB[i]<HoMin)
                {
                    HoMin = HoTMB[i];
                }
                if(HoTMB[i]>HoMax)
                {
                    HoMax = HoTMB[i];
                }
            }
            Console.WriteLine("\tA legalacsonyabb hőmérséklet: {0} °C",HoMin);
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine("Mennyi volt a legmagasabb mért hőmérséklet?");
            Console.WriteLine("\tA legamagasabb hőmérséklet: {0} °C", HoMax);
        }

        private static void Feladat4Hom()
        {
            Console.WriteLine("Hányszor volt a napi hőmérséklet -3 és +3 közötti?");
            int dbKozott = 0;
            for (int i = 0; i < HoTMB.Length; i++)
            {
                if(HoTMB[i]> -3 && HoTMB[i]<3)
                {
                    dbKozott++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal volt a napi hőmérséklet -3 és +3 közötti {0} ", dbKozott);
        }

        private static void Feladat3Hom()
        {
            Console.WriteLine("Átlag januári hőmérséklet");
            int Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < HoTMB.Length; i++)
            {
                Osszeg += HoTMB[i];
            }
            Atlag = (double)Osszeg / HoTMB.Length;
            Console.WriteLine("\tJanuári átlag hőmérséklet: {0:0.0} °C", Atlag);
        }

        private static void Feladat1Hom()
        {
            Console.WriteLine("Feltöltése a Hőmérseklet tömbnek");
            for (int i = 0; i < HoTMB.Length; i++)
            {
                HoTMB[i] = rnd.Next(-10, 8);
            }
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine("Kiiratás");
            for (int i = 0; i < HoTMB.Length; i++)
            {
                Console.WriteLine("\tJanuár {0,-3} : {1,-3} °C",i+1,HoTMB[i]);
            }
        }
    }
}
