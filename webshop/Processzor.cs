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

        double getOrajel()
        {
            return orajel;
        }

        int getMagszam()
        {
            return magSzam;
        }

        string getGyarto()
        {
            return gyarto;
        }
    }
}