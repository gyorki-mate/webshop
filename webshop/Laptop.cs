namespace webshop
{
    public class Laptop: Termek
    {
        private Processzor processzor;
        private Videokartya videokartya;
        private Ram ram;
        private Hattertar hattertar;
        private Kijelzo kijelzo;
        private double suly;
        private int mennyiseg;

        public Laptop(int id, string nev, int ar, Processzor processzor, Videokartya videokartya, Ram ram, Hattertar hattertar, Kijelzo kijelzo, double suly, int mennyiseg) : base(id, nev, ar)
        {
            this.processzor = processzor;
            this.videokartya = videokartya;
            this.ram = ram;
            this.hattertar = hattertar;
            this.kijelzo = kijelzo;
            this.suly = suly;
            this.mennyiseg = mennyiseg;
        }

        public Processzor getProcesszor()
        {
            return processzor;
        }

        public void setProcesszor(Processzor processzor)
        {
            this.processzor = processzor;
        }

        public Videokartya getVideokartya()
        {
            return videokartya;
        }

        public void setVideokartya(Videokartya videokartya)
        {
            this.videokartya = videokartya;
        }

        public Ram getRam()
        {
            return ram;
        }

        public void setRam(Ram ram)
        {
            this.ram = ram;
        }

        public Hattertar getHattertar()
        {
            return hattertar;
        }

        public void setHattertar(Hattertar hattertar)
        {
            this.hattertar = hattertar;
        }

        public Kijelzo getKijelzo()
        {
            return kijelzo;
        }

        public void setKijelzo(Kijelzo kijelzo)
        {
            this.kijelzo = kijelzo;
        }

        public double getSuly()
        {
            return suly;
        }

        public void setSuly(double suly)
        {
            this.suly = suly;
        }

        public int getMennyiseg()
        {
            return mennyiseg;
        }

        public void setMennyiseg(int mennyiseg)
        {
            this.mennyiseg = mennyiseg;
        }
    }
}