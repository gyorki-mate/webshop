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

        int getMeret()
        {
            return meret;
        }

        double getSebesseg()
        {
            return sebesseg;
        }
    }
}