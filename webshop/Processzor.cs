namespace webshop
{
    public class Processzor: Termek
    {
        private double orajel;
        private int magSzam;
        private string gyarto;

        public Processzor(int id, string nev, int ar, double orajel, int magSzam, string gyarto) : base(id, nev, ar)
        {
            this.orajel = orajel;
            this.magSzam = magSzam;
            this.gyarto = gyarto;
        }

        public double getOrajel()
        {
            return orajel;
        }

        public int getMagszam()
        {
            return magSzam;
        }

        public string getGyarto()
        {
            return gyarto;
        }
    }
}