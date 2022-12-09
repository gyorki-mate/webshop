using System.Collections.Generic;

namespace webshop
{
    public class Kijelzo: Termek
    {
        private int meret;
        private KeyValuePair<int,int> felbontas;

        public Kijelzo(int id, string nev, int ar, int meret, KeyValuePair<int,int> felbontas) : base(id, nev, ar)
        {
            this.meret = meret;
            this.felbontas = felbontas;
        }

        public int getMeret()
        {
            return meret;
        }

        public KeyValuePair<int,int> getFelbontas()
        {
            return felbontas;
        }
    }
}