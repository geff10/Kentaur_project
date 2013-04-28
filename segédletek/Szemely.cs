using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    class Szemely
    {
        string lakhely;
        string nev;
        string szemelyIgsz;
        DateTime szuletesiDatum;
        string szuletesiHely;
        string zeuszkod;


        public string Nev       //itt van set
        {
            get { return nev; }
            set { nev = value; }
        }
       
        public string SzemelyIgsz       //itt van set
        {
            get { return szemelyIgsz; }
            set { szemelyIgsz = value; }
        }
   
        public DateTime SzuletesiDatum
        {
            get { return szuletesiDatum; }
            set { szuletesiDatum = value; }
        }
      
        public string SzuletesiHely
        {
            get { return szuletesiHely; }
            set { szuletesiHely = value; }
        }
        
        public string Zeuszkod
        {
            get { return zeuszkod; }
            set { zeuszkod= value; }
        }

        public string Lakhely //itt van set
        {
            get { return lakhely; }
            set { lakhely = value; }
        }

        public Szemely(string lakhely, string nev, string szemelyIgsz, DateTime szuletesiDatum,
                        string szuletesiHely, string zeuszkod)
        {
            this.lakhely = lakhely;
            this.nev = nev;
            this.szemelyIgsz = szemelyIgsz;
            this.szuletesiDatum = szuletesiDatum;
            this.szuletesiHely = szuletesiHely;
            this.zeuszkod = zeuszkod;

        }

        public override string ToString()
        {
            return "Zeuszkód: " + zeuszkod + "Név: " + nev + ", Lakhely: " + lakhely + ", Igazolványszám: " + szemelyIgsz + ", Születési dátum: " + szuletesiDatum + ", Születési hely: " + szuletesiHely;
        }

        private void delete() //kell ez ide? sztem belülről nem tudjuk törölni
        {
            
        }
    }

    class Hallgato : Szemely
    {
        bool aktiv = true;
        bool vegzett = false;
        List<string> felvettTargyak;  //ez majd list  tantárgy lesz

        public bool Aktiv
        {
            get { return aktiv; }
            set { aktiv = value; }
        }
        
        public List<string> FelvettTargyak
        {
            get { return felvettTargyak; }
            set { felvettTargyak = value; }
        }
        
        public bool Vegzett
        {
            get { return vegzett; }
            set { vegzett = value; }
        }

        public Hallgato(string h_zeuszkod, string h_nev, string h_lakhely, string h_szemelyigsz, DateTime h_szuletesidatum, string h_szuletesihely, bool h_aktiv, bool h_vegzett)
            : base(h_lakhely, h_nev, h_szemelyigsz, h_szuletesidatum, h_szuletesihely, h_zeuszkod)
        {
            this.aktiv = h_aktiv;
            this.vegzett = h_vegzett;
        }

        private void setOsszesadat(string zeuszkod, string nev, string lakhely, string szemelyigsz, DateTime szuldatum, string szulhely, bool aktiv, bool vegzett)
        {
            if (zeuszkod != "")
                Zeuszkod = zeuszkod;

            if (nev != "")
                Nev = nev;

            if (lakhely != "")
                Lakhely = lakhely;

            if (szemelyigsz != "")
                SzemelyIgsz = szemelyigsz;

            if (szuldatum != null)
                SzuletesiDatum = szuldatum;

            if (szulhely != "")
                SzuletesiHely = szulhely;
            
            if (aktiv != null)
                Aktiv = aktiv;

            if (vegzett != null)
                Vegzett = vegzett;

        }

        private string getOsszesadat() //diagramon itt void van, azzel nem jó, legalább stringet kell visszadobnia, void-ra nem tudok visszaadni semmit
        {
            return Zeuszkod.ToString() + " ; " + Nev.ToString() + " ; " + Lakhely.ToString() + " ; " + SzemelyIgsz.ToString() + " ; " + SzuletesiDatum.ToString() + " ; " + SzuletesiHely.ToString() + " ; " + Aktiv.ToString() + " ; " + Vegzett.ToString();
        }

        private void setPassziv()
        {
            Aktiv = false;
        }
       
        /* ha lesz tantárgy akkor írjam át
        private void passTantargy()
        {
         * 
        }
         * 
         * */

        private void setTantargy(string tantargy)   //stringgel tesztelem
        {
            FelvettTargyak.Add(tantargy);

        }
       


    }


    class Tanar : Szemely
    {
        string beosztas;

        public string Beosztas
        {
            get { return beosztas; }
            set { beosztas = value; }
        }

        public Tanar(string t_zeusz, string t_nev, string t_lakhely, string t_szemigsz, DateTime t_szuldate, string t_szulhely, string t_beosztas)
            : base(t_lakhely, t_nev, t_szemigsz, t_szuldate, t_szulhely, t_zeusz) //LOL... TÉzeusz.. :D
        {
            this.beosztas=t_beosztas;
        }

        private void setOsszesadat(string zeusz, string nev, string lakhely, string szemigsz, DateTime szuldate, string szulhely, string beosztas)
        {
            if (zeusz != "")        //értelemszerűen ha valami üres akkor marad a régi érték
                Zeuszkod = zeusz;
            if (nev != "")
                Nev = nev;
            if (lakhely != "")
                Lakhely = lakhely;
            if (szemigsz != "")
                SzemelyIgsz = szemigsz;
            if (szuldate != null)
                SzuletesiDatum = szuldate;
            if (szulhely != "")
                SzuletesiHely = szulhely;
            if (beosztas != "")
                Beosztas = beosztas;
        }

        private void KimutatasKeszites(Object o)
        {
            //na ezt k*ra nem tudm mit kéne ide
        }

        private void hallgatoErtekeles(Félév_évfolyam félév, string tantárgy, Hallgato hallgato, int jegy)
        { 
            //stringes verzió..majd kell db meg többiek hozzá
        
        }

        private void hallgatoErtekelesModositas(Félév_évfolyam félév, string tantárgy, Hallgato hallgato, int mit, int mire)
        {
            //még írjam meg
        }

        private string getOsszesadat()
        {
            //szintén legalább string kell neki a returnhoz
            return Zeuszkod.ToString() + " ; " + Nev.ToString() + " ; " + Lakhely.ToString() + " ; " + SzemelyIgsz.ToString() + " ; " + SzuletesiDatum.ToString() + " ; " + SzuletesiHely.ToString() + " ; " + Beosztas.ToString();
        }


    }

    enum Évfolyam
    {
        Első,
        Második, 
        Harmadik, 
        Negyedik        
    }
    struct Félév_évfolyam       //nem vagyok ebben teljesen biztos, lehet osztály kéne belőle....
    {
        Évfolyam éf;
        int félév;

    }

    class Vezeto : Szemely
    {
        public Vezeto(string v_zeusz, string v_nev, string v_lakhely, string v_szemigsz, DateTime v_szuldate, string v_szulhely)
            : base(v_lakhely, v_nev, v_szemigsz, v_szuldate, v_szulhely, v_zeusz)
        {

        }

        public string getÖsszes()
        {
            return Zeuszkod.ToString() + " ; " + Nev.ToString() + " ; " + Lakhely.ToString() + " ; " + SzemelyIgsz.ToString() + " ; " + SzuletesiDatum.ToString() + " ; " + SzuletesiHely.ToString();
        }

        public void kimutatasKeszites(Object o)
        {
            //ez majd.. :)
        }

        public void setOsszes(string zeusz, string nev, string cim, string szemigsz, DateTime szuldate, string szulhely)
        {
            if (zeusz != "")
                Zeuszkod = zeusz;
            if (nev != "")
                Nev = nev;
            if (cim != "")
                Lakhely = cim;
            if (szemigsz != "")
                SzemelyIgsz = szemigsz;
            if (szuldate != null)
                SzuletesiDatum = szuldate;
            if (szulhely != "")
                SzuletesiHely = SzuletesiHely;
        }

    }
}
