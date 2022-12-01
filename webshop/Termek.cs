namespace webshop
{
    public class Termek
    {
        protected int id;
        protected string nev;
        protected string marka;
        protected int ar;

        //Márka direkt nincs benne?
        public Termek(int id, string nev, int ar)
        {
            this.id = id;
            this.nev = nev;
            this.ar = ar;
        }

        public int getID()
        {
            return id;
        }

        public string getNev()
        {
            return nev;
        }

        public string getMarka()
        {
            return marka;
        }

        public int getAr()
        {
            return ar;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }
    }
}