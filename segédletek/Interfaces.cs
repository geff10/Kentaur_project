using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    interface IAdatkezelő
    {
        //void hallgatóFelvétel(Hallgató újHallgató);
        //void hallgatóMódosítás(Hallgató módosítottHallgató,Hallgató módosítandóHallgató);
        //void hallgatóTörlés(string indoklás,Hallgató hallgató);
        //void hallgatóListázás(List<Hallgató> hallgatók);
        //void passzívFélév(Hallgató hallgató);
        //void tanárFelvétel(Tanár újTanár);
        //void tanárMódosítás(Tanár módosítottTanár,Tanár újTanár);
        //void tanárTörlés(string indoklás, Tanár tanár);
        //void tanárListázás(List<Tanár> tanárok);
        //void vezetőFelvétel(Vezető újVezető);
        //void vezetőMódosítás(Vezető módosítottVezető, Vezető újVezető);
        //void vezetőTörlés(string indoklás, Vezető vezető);
        //void vezetőListázás(List<Vezető> vezetők);
    }

    interface IBejelenkezésKezelő
    {
        //void Beléptetés(string Zeuszkód, string Jelszó);
    }

    interface IKérelemkezelő
    {
        //void Kérelemelbírálás(Kérelem kérelem);
        //void Kérelmezés();
        //void KijeletkezésiKérelem(string Zeuszkód, string indoklás);
        //void PasszívKérelem(string Zeuszkód, string indoklás);
    }

    interface ITantárgykezelő
    {
        //void Tárgyfevétel(Tantárgy tantárgy);
        //void Tárgyleadás(Tantárgy tantárgy);
        //void Tárgyhozzáadás(Tantárgy tantárgy);
        //void Tárgymódosítás(Tantárgy tárgyról, Tantárgy tárgyra);
        //void Tárgytörlés(Tantárgy tantárgy);
        //void tantárgyListázás(List<Tantárgy>);
    }

    interface IÜzenetkezelő
    {
        //void üzenetKüldés(Üzenet üzenet);
        //void üzenetTörlés(Üzenet üzenet);
        //void üzenetKiíratás(Üzenet üzenet);
        //void üzenetListázás(List<Üzenet>);
    }
}
