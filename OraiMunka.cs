using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore
{
    class Tanulo
    {
        #region Fieald-ek
        string nev;
        double atlag;
        string szemszam;
        #endregion

        #region Property-k
        // Ne legyen később módosítható , de ne lehessen üresen létrehozni
        public string Nev
        {
            get => nev;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    nev = value;
                }
                else
                {
                    nev = "HIBÁS";
                    // TODO hibakezelés majd később jön ide, ilyenkor hibát kell dobni.
                }
            }
        }
        // Később is módosítható legyen, de csak 1 és 5 közötti értéket vehet fel
        public double Atlag
        {
            get => atlag;
            set
            {
                if (value >= 1 && value <= 5)
                {
                    atlag = value;
                }
                else
                {
                    atlag = -1;
                    // TODO hibakezelés majd később jön ide, ilyenkor hibát kell dobni.
                }
            }
        }
        // Ne legyen módosítható, de jelenleg nem alkalmazunk rá semmilyen bemeneti feltételt
        public string Szemszam { get => szemszam; /* set => szemszam = value; */ }  // Ki lehet venni mert nem használjuk vagy 'private set => szemszam = value;'

        public Tanulo(string szemszam, string nev, double atlag)
        {
            this.szemszam = szemszam;
            Nev = nev;
            Atlag = atlag;
        }
        #endregion

        #region Konstruktor
        public Tanulo(string nev, double atlag, string szemszam)
        {
            // Biztosítani kell, hogy a kapott parametereket át tudjuk vezetni az objektum szintű változókba (field-ekbe)
            Nev = nev; // Nev-nek adjuk nev-et, hogy ne legyen nev = nev ütközés
            Atlag = atlag;
            this.szemszam = szemszam; // Szemszam nem fog műköni mert nincs set-je a property-ben ezért kell a this jelölő a mögötte álló dolog az objetum része nem az alprogramé
        }

        #endregion

        #region Alprogramok

        // Jelenleg ide nem kell semmi

        #endregion
    }

}
