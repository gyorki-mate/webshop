namespace webshop
{
    public class Ram: Termek
    {
        private int meret;
        private double sebesseg;

        public Ram(int id, string nev, int ar, int meret, double sebesseg) : base(id, nev, ar)
        {
            this.meret = meret;
            this.sebesseg = sebesseg;
        }

        public int getMeret()
        {
            return meret;
        }

        public double getSebesseg()
        {
            return sebesseg;
        }
    }
}