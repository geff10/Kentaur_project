using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    interface IAdatkezelő
    {
        void hallgatóFelvétel(Hallgató újHallgató);
        void hallgatóMódosítás(Hallgató módosítottHallgató, Hallgató módosítandóHallgató);
        void hallgatóTörlés(string indoklás, Hallgató hallgató);
        List<Hallgató> hallgatóListázás();
        void passzívFélév(Hallgató hallgató);
        void tanárFelvétel(Tanár újTanár);
        void tanárMódosítás(Tanár módosítottTanár, Tanár újTanár);
        void tanárTörlés(string indoklás, Tanár tanár);
        List<Tanár> tanárListázás();
        void vezetőFelvétel(Vezető újVezető);
        void vezetőMódosítás(Vezető módosítottVezető, Vezető újVezető);
        void vezetőTörlés(string indoklás, Vezető vezető);
        List<Vezető> vezetőListázás();
        void Jelszómódosítás(Személy személy, string újjelszó);
        bool Jelszóellenőrzés(string zeuszkód, string jelszó);
    }

    interface IBejelenkezésKezelő
    {
        void Beléptetés(string Zeuszkód, string Jelszó);
    }

    interface IKérelemkezelő
    {
        void Kérelemelbírálás(Kérelem kérelem);
        void Kérelmezés(string típus, Kérelem kérelem);
        List<Kérelem> kérelemListázás();
        
    }

    interface ITantárgykezelő
    {
        void Tárgyfelvétel(Tantárgy tantárgy, string hallgatóZeuszkód);
        void Tárgyleadás(Tantárgy tantárgy, string hallgatóZeuszkód);
        void Tárgyhozzáadás(Tantárgy tantárgy);
        void Tárgymódosítás(Tantárgy tárgyról, Tantárgy tárgyra);
        void Tárgytörlés(Tantárgy tantárgy);
        List<Tantárgy> tantárgyListázás();
        List<Tantárgy> tantárgyListázás(string tanárZeuszkód);
    }

    interface IÜzenetkezelő
    {
        void üzenetKüldés();
        void üzenetTörlés(Üzenet üzenet);
        void üzenetKiíratás(Üzenet üzenet);
        List<Üzenet> üzenetListázás(string zeusz, bool mindet);
    }
}
