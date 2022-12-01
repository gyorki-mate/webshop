using System.Linq;

namespace webshop
{
    public class Szerencsekerek
    {
        private string[] nyeremenyek;
        
        //konstruktor no kell?

        public void porgetes(Felhasznalo felhasznalo)
        {
            //TODO
            //nem biztos hogy a kerek porget
        }

        public string[] nyeremenyekListazasa()
        {
            //TODO
            return null;
        }

        public void ujNyeremenyekFelvetele(string ujNyeremeny)
        {
            //TODO
        }

        public void nyeremenyTorlese(string nyeremeny)
        {
            //delete nyeremeny from nyeremenyek array
            //TODO
            nyeremenyek = nyeremenyek.Where((x) => x != nyeremeny).ToArray();
        }
    }
}