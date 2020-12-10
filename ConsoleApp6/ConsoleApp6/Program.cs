using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static int[] JanuariHomersekletTMB = new int[31];
        static int[] Orak = new int[14];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            JanuariFeladat();
            MegatrtottOra();
            Console.ReadKey();
        }

        private static void MegatrtottOra()
        {
            Feladat1FeltoltFeltoltMeg(); Console.WriteLine("\n------------------------------------\n");
            Feladat2BevetelMeg(); Console.WriteLine("\n------------------------------------\n");
            Feladat3EgyoraMeg(); Console.WriteLine("\n------------------------------------\n");
            Feladat4MaxMeg(); Console.WriteLine("\n------------------------------------\n");
            Feladat5Volt6Meg(); Console.WriteLine("\n------------------------------------\n");
            Feladat6CsereMeg(); Console.WriteLine("\n------------------------------------\n");
        }
      

        private static void Feladat6CsereMeg()
        {
            Console.WriteLine("Írjuk ki az értékeket növekvő rendben!");
            int CsereSzam;
            for (int i = 0; i < Orak.Length-1; i++)
            {
                for (int j = 0; j < Orak.Length-1; j++)
                {
                    if(Orak[j]>Orak[j+1])
                    {
                        CsereSzam = Orak[j];
                        Orak[j] = Orak[j + 1];
                        Orak[j + 1] = CsereSzam;
                    }
                }
            }
            for (int k = 0; k < Orak.Length; k++)
            {
                Console.Write("{0} , ", Orak[k]);
            }
        }

        private static void Feladat5Volt6Meg()
        {
            Console.WriteLine("Volt-e 6 órája valamikor?");
            bool Dontes = false;
            for (int i = 0; i < Orak.Length; i++)
            {
                if(Orak[i]==6)
                { Dontes = true; }
            }
            if(Dontes==true)
            {
                Console.WriteLine("Volt ilyen napja");
            }
            else
            {
                Console.WriteLine("Nem volt ilyen napja");
            }
        }

        private static void Feladat4MaxMeg()
        {
            Console.WriteLine("Mennyi volt a legtöbb megtartott órája?");
            int Max = int.MinValue;
            for (int i = 0; i < Orak.Length; i++)
            {
                if(Orak[i]>Max)
                {
                    Max = Orak[i];
                }
            }
            Console.WriteLine("\tA legtöbb megtartott óra: {0}", Max);
        }

        private static void Feladat3EgyoraMeg()
        {
            Console.WriteLine("Hányszor tartott 1 órát ?");
            int db = 0;
            for (int i = 0; i < Orak.Length; i++)
            {
                if(Orak[i]==1)
                { db++; }
            }
            Console.WriteLine("Ennyi alkalommal tartott 1 órát: {0}", db);
        }

        private static void Feladat2BevetelMeg()
        {
            Console.WriteLine("Adjuk meg, hogy mennyi pénzt keresett a tanár, ha nettó 2200 Ft - ot kap egy óráért!(összeg * óradíj)");
            int Osszeg = 0;
            for (int i = 0; i < Orak.Length; i++)
            {
                Osszeg += Orak[i];
            }
            int Fizetes = Osszeg * 2200;
            Console.WriteLine("A tanár bevétele : {0} Ft", Fizetes);
        }

        private static void Feladat1FeltoltFeltoltMeg()
        {
            Console.WriteLine("Feltöltés, Kiiratas");
            for (int i = 0; i < Orak.Length; i++)
            {
                Orak[i] = rnd.Next(1,9);
                Console.WriteLine("{0}. nap őraszáma: {1}",i+1,Orak[i]);
            }
        }

        private static void JanuariFeladat()
        {
            Feladat1FeltoltJan(); Console.WriteLine("\n------------------------------------\n");
            Feladat2AtlagJan(); Console.WriteLine("\n------------------------------------\n");
            Feladat3KozottJan(); Console.WriteLine("\n------------------------------------\n");
            Feladat45MinMax(); Console.WriteLine("\n------------------------------------\n");
            Feladat6HetVoltJan(); Console.WriteLine("\n------------------------------------\n");
            Feladat7RendezesJan(); Console.WriteLine("\n------------------------------------\n");
        }

        private static void Feladat7RendezesJan()
        {
            Console.WriteLine("Írjuk ki a hőmérséklet értékeket növekvő rendben");
            int CsereHomerseklet;
            for (int i = 0; i < JanuariHomersekletTMB.Length-1; i++)
            {
                for (int j = 0; j < JanuariHomersekletTMB.Length-1; j++)
                {
                    if(JanuariHomersekletTMB[j]>JanuariHomersekletTMB[j+1])
                    {
                        CsereHomerseklet = JanuariHomersekletTMB[j];
                        JanuariHomersekletTMB[j] = JanuariHomersekletTMB[j + 1];
                        JanuariHomersekletTMB[j + 1] = CsereHomerseklet;
                    }
                }
            }
            for (int i = 0; i < JanuariHomersekletTMB.Length; i++)
            {
                Console.Write("{0} , ",JanuariHomersekletTMB[i]);
            }
        }

        private static void Feladat6HetVoltJan()
        {
            Console.WriteLine("Volt-e + 7 fok a hőmérséklet valamelyik napon ?");
            bool Igaze = false;
            //int VanIlyen = 0;
            for (int i = 0; i < JanuariHomersekletTMB.Length; i++)
            {
                if(JanuariHomersekletTMB[i]==7)
                {
                    Igaze = true;
                   // VanIlyen++;
                }
            }
            if(Igaze==true)//if(VanIlyen>0)
            { Console.WriteLine("\tVolt ilyen nap"); }
            else
            { Console.WriteLine("\tNem volt ilyen nap"); }
            
        }

        private static void Feladat45MinMax()
        {
            Console.WriteLine("Mennyi volt a legalacsonyabb mért hőmérséklet? Mennyi volt a legmagasabb mért hőmérséklet ? ");
            int Min = int.MaxValue;
            int Max = int.MinValue;
            for (int i = 0; i < JanuariHomersekletTMB.Length; i++)
            {
                if(JanuariHomersekletTMB[i]<Min)
                {
                    Min = JanuariHomersekletTMB[i];
                }
                if(JanuariHomersekletTMB[i]>Max)
                {
                    Max = JanuariHomersekletTMB[i];
                }
            }
            Console.WriteLine("\tJanuár legalacsonyabb hőmérséklete: {0}", Min);
            Console.WriteLine("\tJanuár legmagasabb hőmérséklete: {0}", Max);
        }

        private static void Feladat3KozottJan()
        {
            Console.WriteLine("Hányszor volt a napi hőmérséklet -3 és +3 közötti?");
            int db = 0;
            for (int i = 0; i < JanuariHomersekletTMB.Length; i++)
            {
                if(JanuariHomersekletTMB[i]>-3 && JanuariHomersekletTMB[i]<3)
                { db++; }
            }
            Console.WriteLine("\tEnnyi alkalommal volt a hőmérséklet -3 és +3 közötti:  {0}",db);
        }

        private static void Feladat2AtlagJan()
        {
            Console.WriteLine("Januári hőmérséklet átlaga");
            int Osszeg = 0;
            for (int i = 0; i < JanuariHomersekletTMB.Length; i++)
            {
                Osszeg += JanuariHomersekletTMB[i];
            }
            double Atlag = (double)Osszeg / JanuariHomersekletTMB.Length;
            Console.WriteLine("\tJanuári hónap hőmérsékleteinek átlaga: {0:0.0}",Atlag);
        }

        private static void Feladat1FeltoltJan()
        {
            Console.WriteLine("Tömb elemeinek feltöltése, Kiiratása");
            for (int i = 0; i < JanuariHomersekletTMB.Length; i++)
            {
                JanuariHomersekletTMB[i] = rnd.Next(-10, 8);
                Console.WriteLine("Január {0} -> {1} °C", i+1,JanuariHomersekletTMB[i]);
            }
            Console.WriteLine("\n------------------------------------\n");
            int k = 0;
            foreach (var j in JanuariHomersekletTMB)
            {
                k++;
                Console.WriteLine("Január {0} -> {1} °C",k, j);
            }           
        }
    }
}
