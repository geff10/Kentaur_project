using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    class Kérelem   //kérelem ős, passzív illetve kijelentkezési kérelem
    {               //false passzív_kijelentkezési esetén kijelentkezési kérelem, true esetén passzív
        private bool aktív;
        public bool Aktív
        {
            get { return aktív; }
            set { aktív = value; }
        }

        private DateTime elbírálásDátum;
        public DateTime ElbírálásDátum
        {
            get { return elbírálásDátum; }
            set { elbírálásDátum = value; }
        }

        private bool elfogadva;
        public bool Elfogadva
        {
            get { return elfogadva; }
            set { elfogadva = value; }
        }

        private string feladó;
        public string Feladó
        {
            get { return feladó; }
            set { feladó = value; }
        }
        private string indoklás;
        public string Indoklás
        {
            get { return indoklás; }
            set { indoklás = value; }
        }

        private DateTime küldésDátum;
        public DateTime KüldésDátum
        {
            get { return küldésDátum; }
            set { küldésDátum = value; }
        }

        private int kérelemAzonosító;
        public int KérelemAzonosító
        {
            get { return KérelemAzonosító; }
            set { KérelemAzonosító = value; }
        }

        private bool passzív_kijelentkezési;
        public bool Passzív_kijelentkezési
        {
            get { return passzív_kijelentkezési; }
            set { passzív_kijelentkezési = value; }
        }

        public Kérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési)
        {
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public Kérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum,
           int KérelemAzonosító, bool passzív_kijelentkezési)
        {
            this.aktív = aktív;
            this.elbírálásDátum = elbírálásDátum;
            this.elfogadva = elfogadva;
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
        }

        public void elfogad()
        {
            elfogadva = true;
            aktív = false;
            //módosít az adatbázisban, megírni
        }

        public void elutasít()
        {
            aktív = false;
            //módosítást adatbázisba megírni
        }
    }

    class hallgMódKérelem : Kérelem   //hallgató módosítása
    {
        private Hallgató mireMódosít;
        public Hallgató MireMódosít
        {
            get { return mireMódosít; }
            set { mireMódosít = value; }
        }
       
        public hallgMódKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Hallgató mireMódosít)
            : base(feladó,indoklás,küldésDátum,passzív_kijelentkezési)
        {
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
            Aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            Elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public hallgMódKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Hallgató mireMódosít)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.Aktív = aktív;
            this.ElbírálásDátum = elbírálásDátum;
            this.Elfogadva = elfogadva;
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
        }
    }

    class tantárgyHozzáadKérelem : Kérelem   //tantárgy hozzáadása
    {
        private Tantárgy újTantárgy;
        public Tantárgy ÚjTantárgy
        {
            get { return újTantárgy; }
            set { újTantárgy = value; }
        }

        public tantárgyHozzáadKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Tantárgy újTantárgy)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.újTantárgy = újTantárgy;
            Aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            Elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyHozzáadKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Tantárgy újTantárgy)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.Aktív = aktív;
            this.ElbírálásDátum = elbírálásDátum;
            this.Elfogadva = elfogadva;
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.újTantárgy = újTantárgy;
        }
    }

    class tanárMódKérelem : Kérelem   //tanár módosítása
    {
        private Tanár mireMódosít;
        public Tanár MireMódosít
        {
            get { return mireMódosít; }
            set { mireMódosít = value; }
        }

        public tanárMódKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Tanár mireMódosít)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
            Aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            Elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tanárMódKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int kérelemAzonosító,
            bool passzív_kijelentkezési, Tanár mireMódosít)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, kérelemAzonosító, passzív_kijelentkezési)
        {
            this.Aktív = aktív;
            this.ElbírálásDátum = elbírálásDátum;
            this.Elfogadva = elfogadva;
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.KérelemAzonosító = kérelemAzonosító;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
        }
    }

    class tantárgyMódKérelem : Kérelem   //tantárgy módosítása
    {
        private string miről_Tárgykód;
        public string Miről_Tárgykód
        {
            get { return miről_Tárgykód; }
            set { miről_Tárgykód = value; }
        }

        private Tantárgy mireMódosít;
        public Tantárgy MireMódosít
        {
            get { return mireMódosít; }
            set { mireMódosít = value; }
        }

        public tantárgyMódKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, string miről_Tárgykód, Tantárgy mireMódosít)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.miről_Tárgykód = miről_Tárgykód;
            this.mireMódosít = mireMódosít;
            Aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            Elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyMódKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, string miről_Tárgykód, Tantárgy mireMódosít)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.Aktív = aktív;
            this.ElbírálásDátum = elbírálásDátum;
            this.Elfogadva = elfogadva;
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.miről_Tárgykód = miről_Tárgykód;
            this.mireMódosít = mireMódosít;
        }
    }

    class tantárgyTörlésKérelem : Kérelem   //tantárgy törlése
    {
        private Tantárgy törlTantárgy;
        public Tantárgy TörlTantárgy
        {
            get { return törlTantárgy; }
            set { törlTantárgy = value; }
        }

        public tantárgyTörlésKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Tantárgy törlTantárgy)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.törlTantárgy = törlTantárgy;
            Aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            Elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyTörlésKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Tantárgy törlTantárgy)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.Aktív = aktív;
            this.ElbírálásDátum = elbírálásDátum;
            this.Elfogadva = elfogadva;
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.törlTantárgy = törlTantárgy;
        }
    }

    class tantárgyLeadásKérelem : Kérelem   //tantárgy leadása
    {
        private string zeusz;
        public string Zeusz
        {
            get { return zeusz; }
            set { zeusz = value; }
        }

        private Tantárgy leadTantárgy;
        public Tantárgy LeadTantárgy
        {
            get { return leadTantárgy; }
            set { leadTantárgy = value; }
        }

        public tantárgyLeadásKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, string zeusz, Tantárgy leadTantárgy)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.zeusz = zeusz;
            this.leadTantárgy = leadTantárgy;
            Aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            Elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyLeadásKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési,string zeusz, Tantárgy leadTantárgy)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.Aktív = aktív;
            this.ElbírálásDátum = elbírálásDátum;
            this.Elfogadva = elfogadva;
            this.Feladó = feladó;
            this.Indoklás = indoklás;
            this.KüldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.Passzív_kijelentkezési = passzív_kijelentkezési;
            this.zeusz = zeusz;
            this.leadTantárgy = leadTantárgy;
        }
    }
}
