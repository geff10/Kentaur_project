using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Zeusz 
{
	public class Üzenet 
    {
        string[] címzettek;
        public string[] Címzettek
        {
            get { return címzettek; }
            set { címzettek = value; }
        }

		        
        bool elolvasva;
        public bool Elolvasva
        {
            get { return elolvasva; }
            set { elolvasva = value; }
        }

		
        string feladó;
        public string Feladó
        {
            get { return feladó; }
            set { feladó = value; }
        }

		DateTime küldésDátum;
        public DateTime KüldésDátum
        {
            get { return küldésDátum; }
            set { küldésDátum = value; }
        }


		string tárgy;
        public string Tárgy
        {
            get { return tárgy; }
            set { tárgy = value; }
        }
        
		int üzenetAzonosító;
        public int ÜzenetAzonosító
        {
            get { return üzenetAzonosító; }
            set { üzenetAzonosító = value; }
        }
        
        string üzenetSzöveg;
        public string ÜzenetSzöveg
        {
            get { return üzenetSzöveg; }
            set { üzenetSzöveg = value; }
        }



        public Üzenet(string[] ujcímzettek, string ujfeladó, string ujtárgy, string ujüzenetSzöveg)
        {
            címzettek = ujcímzettek;
            elolvasva = false;
            feladó = ujfeladó;
            küldésDátum = System.DateTime.Now;
            tárgy = ujtárgy;
            üzenetAzonosító = 1; //késõbb átírni adatbázisból következõ lekérésre
            üzenetSzöveg = ujüzenetSzöveg;

		}

        public override string ToString()
        {
            return "Címzettek: " + címzettek + "Olvasott: " + elolvasva + "Feladó: " + feladó + "Dátum: " + küldésDátum + "Tárgy: " + tárgy + "Üzenet azonosító: " + üzenetAzonosító + "Szöveg: " + üzenetSzöveg ;
        }

	
		public Üzenet(string[] címzettek, bool elolvasva, string feladó, DateTime küldésiDátum, string tárgy, int üzenetAzonosító, string üzenetSzöveg)
        {
            this.címzettek = címzettek;
            this.elolvasva = elolvasva;
            this.feladó = feladó;
            this.küldésDátum = küldésiDátum;
            this.tárgy = tárgy;
            this.üzenetAzonosító = üzenetAzonosító;
            this.üzenetSzöveg = üzenetSzöveg;

		}

		public void delete()
        {
            //késõbb ab-val
		}

		public string getÖsszesAdat()
        {
            return ÜzenetAzonosító.ToString() + " ; " + Címzettek.ToString() + " ; " + Feladó.ToString() + " ; " + Elolvasva.ToString() + " ; " + küldésDátum.ToString() + " ; " + Tárgy.ToString() + " ; "  + üzenetSzöveg.ToString() + " ; ";
		}

	}//end Üzenet

}//end namespace Hallgatók