using System;

namespace webshop;

public class RendelesTarolo
{
    private Rendeles[] rendelesek;
    
    public RendelesTarolo()
    {
        rendelesek = new Rendeles[0];
        //TODO import from file
    }
    
    public void rendelesHozzaadasa(Rendeles rendeles)
    {
        Rendeles[] temp = new Rendeles[rendelesek.Length + 1];
        for (int i = 0; i < rendelesek.Length; i++)
        {
            temp[i] = rendelesek[i];
        }
        temp[rendelesek.Length] = rendeles;
        rendeles.setID(rendelesek.Length);
        rendelesek = temp;
    }
    
    public Rendeles[] getRendelesek()
    {
        return rendelesek;
    }
    
    public int getOsszesen(Felhasznalo felhasznalo)
    {
        if (rendelesek.Length == 0)
        {
            return 0;
        }
        if (felhasznalo.getTipus() == "admin" || felhasznalo.getTipus() == "manager")
        {
            int osszeg = 0;
            for (int i = 0; i < rendelesek.Length; i++)
            {
                osszeg += rendelesek[i].getOsszeg();
            }
            return osszeg;
        }
        throw new Exception("Nincs jogosultságod!");
    }

    public double atlagosRendelesiOsszeg(Felhasznalo felhasznalo)
    {
        if (felhasznalo.getTipus() == "admin" || felhasznalo.getTipus() == "manager")
        {
          double osszeg = 0;
            for (int i = 0; i < rendelesek.Length; i++)
            {
                osszeg += rendelesek[i].getOsszeg();
            }
            return osszeg / rendelesek.Length;
        }
        throw new Exception("Nincs jogosultságod!");
    }

    public int legnepszerubbTermek(Felhasznalo felhasznalo)
    {
        if (felhasznalo.getTipus() == "admin" || felhasznalo.getTipus() == "manager")
        {
            int max = 0;
            int maxId = 0;
            for (int i = 0; i < rendelesek.Length; i++)
            {
                foreach (var termek in rendelesek[i].kosarMegtekintese())
                {
                  //TODO
                }
            }
            return maxId;
        }
        throw new Exception("Nincs jogosultságod!");
    }

   
}