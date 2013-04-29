using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Zeusz 
{
	class �zenet 
    {
        string c�mzettek;
        //string[] c�mzettek; ?
        public string C�mzettek
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
        
		int �zenetazonos�t�;
        public int �zenetazonos�t�
        {
            get { return �zenetazonos�t�; }
            set { �zenetazonos�t� = value; }
        }
        
        string �zenetSz�veg;
        public string �zenetSz�veg
        {
            get { return �zenetSz�veg; }
            set { �zenetSz�veg = value; }
        }



        public �zenet(string ujc�mzettek, string ujfelad�, DateTime ujk�ld�sD�tum, string ujt�rgy, int uj�zenetazonos�t�, string uj�zenetSz�veg)
        {
            c�mzettek = ujc�mzettek;
            elolvasva = false;
            felad� = ujfelad�;
            k�ld�sD�tum = ujk�ld�sD�tum;
            t�rgy = ujt�rgy;
            �zenetazonos�t� = ...;
            �zenetSz�veg = uj�zenetSz�veg;

		}

        public override string ToString()
        {
            return "C�mzettek: " + c�mzettek + "Olvasott: " + elolvasva + "Felad�: " + felad� + "D�tum: " + k�ld�sD�tum + "T�rgy: " + t�rgy + "�zenet azonos�t�: " + �zenetazonos�t� + "Sz�veg: " + �zenetSz�veg ;
        }

	
		public �zenet(string c�mzettek, bool elolvasva, string felad�, DateTime k�ld�siD�tum, string t�rgy, string �zenetSz�veg, int �zenetazonos�t�)
        {
            this.c�mzettek = c�mzettek;
            this.elolvasva = elolvasva;
            this.felad� = felad�;
            this.k�ld�sD�tum = k�ld�sD�tum;
            this.t�rgy = t�rgy;
            this.�zenetazonos�t� = �zenetazonos�t�;
            this.�zenetSz�veg = �zenetSz�veg;

		}

		public void delete()
        {
            //?
		}

		public string get�sszesAdat()
        {
            return �zenetazonos�t�.ToString() + " ; " + C�mzettek.ToString() + " ; " + Felad�.ToString() + " ; " + Elolvasva.ToString() + " ; " + K�ld�sD�tuma.ToString() + " ; " + T�rgy.ToString() + " ; "  + �zenetSz�vege.ToString();
		}

	}//end �zenet

}//end namespace Hallgat�k