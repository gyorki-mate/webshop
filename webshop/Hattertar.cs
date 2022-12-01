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

        int getMeret()
        {
            return meret;
        }

        string getTipus()
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