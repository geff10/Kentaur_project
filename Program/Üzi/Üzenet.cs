using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Zeusz 
{
	class Üzenet 
    {
        string címzettek;
        //string[] címzettek; ?
        public string Címzettek
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
        
		int üzenetazonosító;
        public int Üzenetazonosító
        {
            get { return üzenetazonosító; }
            set { üzenetazonosító = value; }
        }
        
        string üzenetSzöveg;
        public string ÜzenetSzöveg
        {
            get { return üzenetSzöveg; }
            set { üzenetSzöveg = value; }
        }



        public Üzenet(string ujcímzettek, string ujfeladó, DateTime ujküldésDátum, string ujtárgy, int ujüzenetazonosító, string ujüzenetSzöveg)
        {
            címzettek = ujcímzettek;
            elolvasva = false;
            feladó = ujfeladó;
            küldésDátum = ujküldésDátum;
            tárgy = ujtárgy;
            üzenetazonosító = ...;
            üzenetSzöveg = ujüzenetSzöveg;

		}

        public override string ToString()
        {
            return "Címzettek: " + címzettek + "Olvasott: " + elolvasva + "Feladó: " + feladó + "Dátum: " + küldésDátum + "Tárgy: " + tárgy + "Üzenet azonosító: " + üzenetazonosító + "Szöveg: " + üzenetSzöveg ;
        }

	
		public Üzenet(string címzettek, bool elolvasva, string feladó, DateTime küldésiDátum, string tárgy, string üzenetSzöveg, int Üzenetazonosító)
        {
            this.címzettek = címzettek;
            this.elolvasva = elolvasva;
            this.feladó = feladó;
            this.küldésDátum = küldésDátum;
            this.tárgy = tárgy;
            this.üzenetazonosító = üzenetazonosító;
            this.üzenetSzöveg = üzenetSzöveg;

		}

		public void delete()
        {
            //?
		}

		public string getÖsszesAdat()
        {
            return Üzenetazonosító.ToString() + " ; " + Címzettek.ToString() + " ; " + Feladó.ToString() + " ; " + Elolvasva.ToString() + " ; " + KüldésDátuma.ToString() + " ; " + Tárgy.ToString() + " ; "  + ÜzenetSzövege.ToString();
		}

	}//end Üzenet

}//end namespace Hallgatók