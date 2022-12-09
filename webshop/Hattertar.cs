namespace webshop
{
    public class Hattertar : Termek
    {
        private int meret;
        private string tipus;

        public Hattertar(int id, string nev, int ar, int meret, string tipus) : base(id, nev, ar)
        {
            this.meret = meret;
            this.tipus = tipus;
        }

        public int getMeret()
        {
            return meret;
        }

        public string getTipus()
        {
            return tipus;
        }
        
        //probably cool idk
        public override string ToString()
        {
            return base.ToString() + " " + meret + " " + tipus;
        }
    }
}