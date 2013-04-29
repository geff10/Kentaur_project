using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    class Kérelem   //kérelem ős, passzív illetve kijelentkezési kérelem
    {               //false passzív_kijelentkezési esetén kijelentkezési kérelem, true esetén passzív
        protected bool aktív;
        protected DateTime elbírálásDátum;
        protected bool elfogadva;
        protected string feladó;
        protected string indoklás;
        protected DateTime küldésDátum;
        protected int KérelemAzonosító;
        protected bool passzív_kijelentkezési;

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
       
        public hallgMódKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Hallgató mireMódosít)
            : base(feladó,indoklás,küldésDátum,passzív_kijelentkezési)
        {
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
            aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public hallgMódKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Hallgató mireMódosít)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.aktív = aktív;
            this.elbírálásDátum = elbírálásDátum;
            this.elfogadva = elfogadva;
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
        }
    }

    class tantárgyHozzáadKérelem : Kérelem   //tantárgy hozzáadása
    {
        private Tantárgy újTantárgy;

        public tantárgyHozzáadKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Tantárgy újTantárgy)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.újTantárgy = újTantárgy;
            aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyHozzáadKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Tantárgy újTantárgy)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.aktív = aktív;
            this.elbírálásDátum = elbírálásDátum;
            this.elfogadva = elfogadva;
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.újTantárgy = újTantárgy;
        }
    }

    class tanárMódKérelem : Kérelem   //tanár módosítása
    {
        private Tanár mireMódosít;

        public tanárMódKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Tanár mireMódosít)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
            aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tanárMódKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Tanár mireMódosít)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.aktív = aktív;
            this.elbírálásDátum = elbírálásDátum;
            this.elfogadva = elfogadva;
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.mireMódosít = mireMódosít;
        }
    }

    class tantárgyMódKérelem : Kérelem   //tantárgy módosítása
    {
        private string miről_Tárgykód;
        private Tantárgy mireMódosít;

        public tantárgyMódKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, string miről_Tárgykód, Tantárgy mireMódosít)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.miről_Tárgykód = miről_Tárgykód;
            this.mireMódosít = mireMódosít;
            aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyMódKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, string miről_Tárgykód, Tantárgy mireMódosít)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.aktív = aktív;
            this.elbírálásDátum = elbírálásDátum;
            this.elfogadva = elfogadva;
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.miről_Tárgykód = miről_Tárgykód;
            this.mireMódosít = mireMódosít;
        }
    }

    class tantárgyTörlésKérelem : Kérelem   //tantárgy törlése
    {
        private Tantárgy törlTantárgy;

        public tantárgyTörlésKérelem(string feladó, string indoklás, DateTime küldésDátum,
            bool passzív_kijelentkezési, Tantárgy törlTantárgy)
            : base(feladó, indoklás, küldésDátum, passzív_kijelentkezési)
        {
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.törlTantárgy = törlTantárgy;
            aktív = true;
            KérelemAzonosító = 0; //később átírni adatbázisból következő lekérésre
            elfogadva = false;
            //létrehoz az adatbázisban, megírni
        }

        public tantárgyTörlésKérelem(bool aktív, DateTime elbírálásDátum, bool elfogadva,
           string feladó, string indoklás, DateTime küldésDátum, int KérelemAzonosító,
            bool passzív_kijelentkezési, Tantárgy törlTantárgy)
            : base(aktív, elbírálásDátum, elfogadva, feladó, indoklás,
                küldésDátum, KérelemAzonosító, passzív_kijelentkezési)
        {
            this.aktív = aktív;
            this.elbírálásDátum = elbírálásDátum;
            this.elfogadva = elfogadva;
            this.feladó = feladó;
            this.indoklás = indoklás;
            this.küldésDátum = küldésDátum;
            this.KérelemAzonosító = KérelemAzonosító;
            this.passzív_kijelentkezési = passzív_kijelentkezési;
            this.törlTantárgy = törlTantárgy;
        }
    }
}
