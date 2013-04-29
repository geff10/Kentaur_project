using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    class Kérelemkezelő: IKérelemkezelő
    {
        public void Kérelemelbírálás(Kérelem kérelem)
        {
            //jó gombra kattintva
            kérelem.elfogad();
            //elutasításra
            kérelem.elutasít();
            //adatbázisban módosítani
            //Üzenet üzenet = new Üzenet(konstruktor);
            //Üzenetkezelő.üzenetKüldés(üzenet);
        }

        public void Kérelmezés(string típus)
        {
            switch (típus){
                case "hallgatómód":
                    {
                        //hallgMódKérelem kérelem = new hallgMódKérelem(adatok beolvasása);
                        break;
                    }
                case "passzív":
                    {
                        //Kérelem kérelem = new Kérelem(adatok beolvasáa);
                        break;
                    }
                case "kijelentkezési":
                    {
                        //Kérelem kérelem = new Kérelem(adatok beolvasáa);
                        break;
                    }
                case "újtárgy":
                    {
                        //tantárgyHozzáadKérelem kérelem = new tantárgyHozzáadKérelem(adatok beolvasáa);
                        break;
                    }
                case "tanármód":
                    {
                        //tanárMódKérelem kérelem = new tanárMódKérelem(adatok beolvasása);
                        break;
                    }
                case "tantárgymód":
                    {
                        //tantárgyMódKérelem kérelem = new tantárgyMódKérelem(adatok be);
                        break;
                    }
                case "tantárgytörl":
                    {
                        //tantárgyTörlésKérelem kérelem = new tantárgyTörlésKérelem(adatbe);
                        break;
                    }
            }
            //adatbázisnak elküld
        }

        public List<Kérelem> kérelemListázás()
        {
            List<Kérelem> kérelmek = new List<Kérelem>();
            //Kérelem kérelem = new Kérelem(adatbázisból olvasott adatok);
            //kérelmek.Add(kérelem);
            return kérelmek;
        }
    }
}
