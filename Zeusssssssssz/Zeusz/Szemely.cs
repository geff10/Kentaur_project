using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    public class Személy
    {
        string lakhely;
        string név;
        string személyIgsz;
        DateTime születésiDátum;
        string születésiHely;
        string zeuszkód;
        string jelszó = "passw1234";


        public string Név       //itt van set
        {
            get { return név; }
            set { név = value; }
        }
       
        public string SzemélyIgsz       //itt van set
        {
            get { return személyIgsz; }
            set { személyIgsz = value; }
        }
   
        public DateTime SzületésiDátum
        {
            get { return születésiDátum; }
            set { születésiDátum = value; }
        }
      
        public string SzületésiHely
        {
            get { return születésiHely; }
            set { születésiHely = value; }
        }
        
        public string Zeuszkód
        {
            get { return zeuszkód; }
            set { zeuszkód= value; }
        }

        public string Lakhely //itt van set
        {
            get { return lakhely; }
            set { lakhely = value; }
        }
        public string Jelszó
        {
            get { return jelszó; }
            set { jelszó = value; }
        }

        public Személy(string lakhely, string név, string személyIgsz, DateTime születésiDátum,
                        string születésiHely, string zeuszkód)
        {
            this.lakhely = lakhely;
            this.név = név;
            this.személyIgsz = személyIgsz;
            this.születésiDátum = születésiDátum;
            this.születésiHely = születésiHely;
            this.zeuszkód = zeuszkód;

        }

        public override string ToString()
        {
            return "Zeuszkód: " + zeuszkód + "Név: " + név + ", Lakhely: " + lakhely + ", Igazolványszám: " + személyIgsz + ", Születési dátum: " + születésiDátum + ", Születési hely: " + születésiHely;
        }

        private void delete() 
        {
            //kikeresi magát, kitörli az adatbázisből és mindenki boldog :)...csak ő szomorú, mert törölték 
        }
    }

    public class Hallgató : Személy
    {
        bool aktiv=true;
        bool végzett = false;
        List<Tantárgy> felvettTárgyak;  //ez majd list  tantárgy lesz

        public bool Aktiv
        {
            get { return aktiv; }
            set { aktiv = value; }
        }
        
        public List<Tantárgy> FelvettTárgyak
        {
            get { return felvettTárgyak; }
            set { felvettTárgyak = value; }
        }
        
        public bool Végzett
        {
            get { return végzett; }
            set { végzett = value; }
        }

        public Hallgató(string h_zeuszkód, string h_név, string h_lakhely, string h_személyigsz, DateTime h_születésidátum, string h_születésihely, bool h_aktiv, bool h_végzett)
            : base(h_lakhely, h_név, h_személyigsz, h_születésidátum, h_születésihely, h_zeuszkód)
        {
            this.aktiv = h_aktiv;
            this.végzett = h_végzett;
        }

        public void setÖsszesadat(string zeuszkód, string név, string lakhely, string személyigsz, DateTime szüldátum, string szülhely, bool aktiv, bool végzett)
        {
            if (zeuszkód != "")
                Zeuszkód = zeuszkód;

            if (név != "")
                Név = név;

            if (lakhely != "")
                Lakhely = lakhely;

            if (személyigsz != "")
                SzemélyIgsz = személyigsz;

            if (szüldátum != null)
                SzületésiDátum = szüldátum;

            if (szülhely != "")
                SzületésiHely = szülhely;
            
            if (aktiv != null)
                Aktiv = aktiv;

            if (végzett != null)
                Végzett = végzett;

        }

        public string getÖsszesadat() //diagramon itt void van, azzel nem jó, legalább stringet kell visszadobnia, void-ra nem tudok visszaadni semmit
        {
            return Zeuszkód.ToString() + " ; " + Név.ToString() + " ; " + Lakhely.ToString() + " ; " + SzemélyIgsz.ToString() + " ; " + SzületésiDátum.ToString() + " ; " + SzületésiHely.ToString() + " ; " + Aktiv.ToString() + " ; " + Végzett.ToString();
        }

        public void setPassziv()
        {
            Aktiv = false;
        }

        private void passTantargy(Tantárgy tantárgy)
        {
            foreach (Tantárgy t in felvettTárgyak)
            {
                if (t.Tárgykód == tantárgy.Tárgykód)
                {
                    felvettTárgyak.Remove(t);
                }
            }
        }

        public void setTantargy(Tantárgy tantárgy)   //stringgel tesztelem
        {
            FelvettTárgyak.Add(tantárgy);

        }
       


    }


    public class Tanár : Személy
    {
        string beosztas;

        public string Beosztas
        {
            get { return beosztas; }
            set { beosztas = value; }
        }

        public Tanár(string t_zeusz, string t_nev, string t_lakhely, string t_szemigsz, DateTime t_szuldate, string t_szulhely, string t_beosztas)
            : base(t_lakhely, t_nev, t_szemigsz, t_szuldate, t_szulhely, t_zeusz) //LOL... TÉzeusz.. :D
        {
            this.beosztas=t_beosztas;
        }

        public void setOsszesadat(string zeusz, string nev, string lakhely, string szemigsz, DateTime szuldate, string szulhely, string beosztas)
        {
            if (zeusz != "")        //értelemszerűen ha valami üres akkor marad a régi érték
                Zeuszkód = zeusz;
            if (nev != "")
                Név = nev;
            if (lakhely != "")
                Lakhely = lakhely;
            if (szemigsz != "")
                SzemélyIgsz = szemigsz;
            if (szuldate != null)
                SzületésiDátum = szuldate;
            if (szulhely != "")
                SzületésiHely = szulhely;
            if (beosztas != "")
                Beosztas = beosztas;
        }

        public void KimutatasKeszites(Object o)
        {
            //na ezt k*ra nem tudm mit kéne ide
        }

        public void hallgatoErtekeles(Félév_évfolyam félév, string tantárgy, Hallgató hallgato, int jegy)
        { 
            //stringes verzió..majd kell db meg többiek hozzá
        
        }

        public void hallgatóÉrtekelésMódositas(Félév_évfolyam félév, string tantárgy, Hallgató hallgato, int mit, int mire)
        {
            //még írjam meg
        }

        public string getÖsszesadat()
        {
            //szintén legalább string kell neki a returnhoz
            return Zeuszkód.ToString() + " ; " + Név.ToString() + " ; " + Lakhely.ToString() + " ; " + SzemélyIgsz.ToString() + " ; " + SzületésiDátum.ToString() + " ; " + SzületésiHely.ToString() + " ; " + Beosztas.ToString();
        }


    }

    public enum Évfolyam
    {
        Első,
        Második, 
        Harmadik, 
        Negyedik        
    }
    public struct Félév_évfolyam       //nem vagyok ebben teljesen biztos, lehet osztály kéne belőle....
    {
        Évfolyam éf;
        int félév;

    }

    public class Vezető : Személy
    {
        public Vezető(string v_zeusz, string v_név, string v_lakhely, string v_szémigsz, DateTime v_szüldate, string v_szülhely)
            : base(v_lakhely, v_név, v_szémigsz, v_szüldate, v_szülhely, v_zeusz)
        {

        }

        public string getÖsszes()
        {
            return Zeuszkód.ToString() + " ; " + Név.ToString() + " ; " + Lakhely.ToString() + " ; " + SzemélyIgsz.ToString() + " ; " + SzületésiDátum.ToString() + " ; " + SzületésiHely.ToString();
        }

        public void kimutatásKészités(Object o)
        {
            //ez majd.. :)
        }

        public void setÖsszes(string zeusz, string nev, string cim, string szemigsz, DateTime szuldate, string szulhely)
        {
            if (zeusz != "")
                Zeuszkód = zeusz;
            if (nev != "")
                Név = nev;
            if (cim != "")
                Lakhely = cim;
            if (szemigsz != "")
                SzemélyIgsz = szemigsz;
            if (szuldate != null)
                SzületésiDátum = szuldate;
            if (szulhely != "")
                SzületésiHely = SzületésiHely;
        }

    }
}
