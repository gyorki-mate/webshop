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

        Processzor getProcesszor()
        {
            return processzor;
        }

        void setProcesszor(Processzor processzor)
        {
            this.processzor = processzor;
        }

        Videokartya getVideokartya()
        {
            return videokartya;
        }

        void setVideokartya(Videokartya videokartya)
        {
            this.videokartya = videokartya;
        }

        Ram getRam()
        {
            return ram;
        }

        void setRam(Ram ram)
        {
            this.ram = ram;
        }

        Hattertar getHattertar()
        {
            return hattertar;
        }

        void setHattertar(Hattertar hattertar)
        {
            this.hattertar = hattertar;
        }

        Kijelzo getKijelzo()
        {
            return kijelzo;
        }

        void setKijelzo(Kijelzo kijelzo)
        {
            this.kijelzo = kijelzo;
        }

        double getSuly()
        {
            return suly;
        }

        void setSuly(double suly)
        {
            this.suly = suly;
        }

        int getMennyiseg()
        {
            return mennyiseg;
        }

        void setMennyiseg(int mennyiseg)
        {
            this.mennyiseg = mennyiseg;
        }
    }
}