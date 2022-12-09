using System;

namespace webshop
{
    public class Rendeles
    {
        private Felhasznalo felhasznalo;
        private Termek[] kosar;
        private DateTime datum;
        private string cim;
        private int osszeg;
        private int id;
        
        //cím??
        //konstruktor?
        
        public int getID()
        {
            return id;
        }
        
        public void setID(int id)
        {
            this.id = id;
        }

        public Termek[] kosarMegtekintese()
        {
            //TODO
            return kosar;
        }

        public void termekHozzaadasa(Termek termek)
        {
            //TODO
        }

        public void termekTorlese(Termek termek)
        {
            //TODO
        }

        public int getOsszeg()
        {
            //TODO
            return 0;
        }
    }
}