using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;



namespace dotnetcore
{

    class Program
    {

            // TODO Tanulok betöltése fájlból

    static Tanulo[] TanulokBeolvasasa(string fajlnev)
    {
        string[] fajlSorai = File.ReadAllLines(fajlnev);
        Tanulo[] tanulok = new Tanulo[fajlSorai.Length];
        for(int i = 0; i < tanulok.Length; i++)
        {
            string[] felbontottSor = fajlSorai[i].Split(';');
            tanulok[i] = new Tanulo(felbontottSor[0], Convert.ToDouble(felbontottSor[1]), felbontottSor[2]);
        }
        return tanulok;
    }

    // TODO Tanulók átlagának kiszámítása

    static double TanulokAtlaga(Tanulo[] tanulok)
    {
        double atlag = 0;
        for(int i = 0; i < tanulok.Length; i++)
        {
            atlag += tanulok[i].Atlag;
        }
        atlag /= tanulok.Length;
        return atlag;
    }

        static void Main(string[] args)
        {
            Tanulo[] tanulok = TanulokBeolvasasa(@"./tanulok.csv");
            /*for(int i = 0; i < tanulok.Length; i++)
            {
                Console.WriteLine("{0}. tanuló: Név: {1}, Átlag: {2}, Személyiigazolvány szám: {3}", i + 1, tanulok[i].Nev, tanulok[i].Atlag, tanulok[i].Szemszam);
            }
            Console.WriteLine("A beolvasott tanulók átlaga: "+ TanulokAtlaga(tanulok));
            Console.ReadKey();   */       
        }
    }
    
}
