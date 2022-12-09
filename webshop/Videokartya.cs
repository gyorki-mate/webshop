namespace webshop
{
    public class Videokartya : Termek
    {
        private int memoria;
        private double orajel;

        public Videokartya(int id, string nev, int ar, int memoria, double orajel) : base(id, nev, ar)
        {
            this.memoria = memoria;
            this.orajel = orajel;
        }

        public int getMemoria()
        {
            return memoria;
        }

        public double getOrajel()
        {
            return orajel;
        }
    }
}