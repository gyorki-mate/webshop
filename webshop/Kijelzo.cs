namespace webshop
{
    public class Kijelzo: Termek
    {
        private int meret;
        private int[] felbontas;

        public Kijelzo(int id, string nev, int ar, int meret, int[] felbontas) : base(id, nev, ar)
        {
            this.meret = meret;
            this.felbontas = felbontas;
        }

        int getMeret()
        {
            return meret;
        }

        int[] getFelbontas()
        {
            return felbontas;
        }
    }
}