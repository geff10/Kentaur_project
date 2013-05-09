using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Zeusz 
{
	public class �zenet 
    {
        string[] c�mzettek;
        public string[] C�mzettek
        {
            get { return c�mzettek; }
            set { c�mzettek = value; }
        }

		        
        bool elolvasva;
        public bool Elolvasva
        {
            get { return elolvasva; }
            set { elolvasva = value; }
        }

		
        string felad�;
        public string Felad�
        {
            get { return felad�; }
            set { felad� = value; }
        }

		DateTime k�ld�sD�tum;
        public DateTime K�ld�sD�tum
        {
            get { return k�ld�sD�tum; }
            set { k�ld�sD�tum = value; }
        }


		string t�rgy;
        public string T�rgy
        {
            get { return t�rgy; }
            set { t�rgy = value; }
        }
        
		int �zenetAzonos�t�;
        public int �zenetAzonos�t�
        {
            get { return �zenetAzonos�t�; }
            set { �zenetAzonos�t� = value; }
        }
        
        string �zenetSz�veg;
        public string �zenetSz�veg
        {
            get { return �zenetSz�veg; }
            set { �zenetSz�veg = value; }
        }



        public �zenet(string[] ujc�mzettek, string ujfelad�, string ujt�rgy, string uj�zenetSz�veg)
        {
            c�mzettek = ujc�mzettek;
            elolvasva = false;
            felad� = ujfelad�;
            k�ld�sD�tum = System.DateTime.Now;
            t�rgy = ujt�rgy;
            �zenetAzonos�t� = 1; //k�s�bb �t�rni adatb�zisb�l k�vetkez� lek�r�sre
            �zenetSz�veg = uj�zenetSz�veg;

		}

        public override string ToString()
        {
            return "C�mzettek: " + c�mzettek + "Olvasott: " + elolvasva + "Felad�: " + felad� + "D�tum: " + k�ld�sD�tum + "T�rgy: " + t�rgy + "�zenet azonos�t�: " + �zenetAzonos�t� + "Sz�veg: " + �zenetSz�veg ;
        }

	
		public �zenet(string[] c�mzettek, bool elolvasva, string felad�, DateTime k�ld�siD�tum, string t�rgy, int �zenetAzonos�t�, string �zenetSz�veg)
        {
            this.c�mzettek = c�mzettek;
            this.elolvasva = elolvasva;
            this.felad� = felad�;
            this.k�ld�sD�tum = k�ld�siD�tum;
            this.t�rgy = t�rgy;
            this.�zenetAzonos�t� = �zenetAzonos�t�;
            this.�zenetSz�veg = �zenetSz�veg;

		}

		public void delete()
        {
            //k�s�bb ab-val
		}

		public string get�sszesAdat()
        {
            return �zenetAzonos�t�.ToString() + " ; " + C�mzettek.ToString() + " ; " + Felad�.ToString() + " ; " + Elolvasva.ToString() + " ; " + k�ld�sD�tum.ToString() + " ; " + T�rgy.ToString() + " ; "  + �zenetSz�veg.ToString() + " ; ";
		}

	}//end �zenet

}//end namespace Hallgat�k