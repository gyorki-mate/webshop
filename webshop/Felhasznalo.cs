using System;

namespace webshop
{
    public class Felhasznalo
    {
        private string felhasznaloNev;
        private string nev;
        private DateTime szuldat;
        private string jelszo;
        private string tipus;
        private DateTime utolsoPorgetes;
        private string nyeremeny;

        public Felhasznalo(string felhasznaloNev, string nev, DateTime szuldat, string jelszo, string tipus)
        {
            this.felhasznaloNev = felhasznaloNev;
            this.nev = nev;
            this.szuldat = szuldat;
            this.jelszo = jelszo;
            this.tipus = tipus;
        }

        public string getFelhasznaloNev()
        {
            return felhasznaloNev;
        }

        public void setFelhasznaloNev(string felhasznaloNev)
        {
            this.felhasznaloNev = felhasznaloNev;
        }

        public string getNev()
        {
            return nev;
        }

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public DateTime getSzuldat()
        {
            return szuldat;
        }

        public void setSzuldat(DateTime szuldat)
        {
            this.szuldat = szuldat;
        }

        public string getTipus()
        {
            return tipus;
        }

        public void setTipus(string tipus)
        {
            this.tipus = tipus;
        }

        public DateTime getUtolsoPorgetes()
        {
            return utolsoPorgetes;
        }

        public void setUtolsoPorgetes(DateTime utolsoPorgetes)
        {
            this.utolsoPorgetes = utolsoPorgetes;
        }

        public string getNyeremeny()
        {
            return nyeremeny;
        }

        public void setNyeremeny(string nyeremeny)
        {
            this.nyeremeny = nyeremeny;
        }
    }
}