using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace Zeusz
{
    class Adatkezelő:IAdatkezelő
    {
        List<Hallgató> beolvasotthallgatók=new List<Hallgató>();
    

        private string generateZeuszKód()       // még ki kell egészíteni, hogy nézze a teljes listát, hgy lesz e egyezés, mert akkor újat kel generáltatni
        {
            string myZeusz="";
            Random rnd = new Random(); //véletlen az ascii generáláshoz

            for (int i = 0; i < 6; i++)
            {
                myZeusz += Convert.ToChar(rnd.Next(48, 128));
            }
            return myZeusz;
             
        }

        private void HallgatóBeolvasás()
        {

            XDocument doc = XDocument.Load("Hallgató.xml");

            foreach (var p in doc.Descendants("Hallgató"))
            {
                beolvasotthallgatók.Add(new Hallgató(
                
        
                     (string)p.Attribute("Zeuszkód"),
                     (string)p.Element("Név"),
                     (string)p.Element("Lakhely"),
                     (string)p.Element("SzemélyIgazolványSzám"),
                     (DateTime)p.Element("SzületésiDátum"),
                     (string)p.Element("Születésihely"),
                     (bool)p.Element("Aktív"),
                     (bool)p.Element("Végzett"))
                     );
           }
        
        }
        public void hallgatóFelvétel(Hallgató újHallgató)
        {

            újHallgató.Zeuszkód = generateZeuszKód();


            //xmlbe irat
            try
            {

                XDocument doc = XDocument.Load("Hallgató.xml");
                XElement hallgató = new XElement("Hallgató",
                    new XAttribute("Zeuszkód", újHallgató.Zeuszkód),
                    new XElement("Név", újHallgató.Név),
                    new XElement("Lakhely", újHallgató.Lakhely),
                    new XElement("SzemélyIgazolványSzám", újHallgató.SzemélyIgsz),
                    new XElement("SzületésiDátum", újHallgató.SzületésiDátum),
                    new XElement("Születésihely", újHallgató.SzületésiHely),
                    new XElement("FelvettTárgyak", újHallgató.FelvettTárgyak),
                    new XElement("Aktív", újHallgató.Aktiv),
                    new XElement("Végzett", újHallgató.Végzett));
                doc.Element("Hallgatók").Add(hallgató);
                doc.Save("Hallgató.xml");

            }
            catch
            { }

        }
        public void hallgatóMódosítás(Hallgató módosítottHallgató, Hallgató módosítandóHallgató)
        {
            //itt nem értem a kettőt...ez a mit-mire hivatott?
            HallgatóBeolvasás();
            //keres

        }
        public void hallgatóTörlés(string indoklás, Hallgató hallgató)
        {

        }

        public List<Hallgató> hallgatóListázás()    //done
        {
            beolvasotthallgatók.Clear();
            HallgatóBeolvasás();
            return beolvasotthallgatók;
        }
        //void passzívFélév(Hallgató hallgató);
        public void tanárFelvétel(Tanár újTanár)
        {
            újTanár.Zeuszkód = generateZeuszKód();


            //xmlbe irat
            try
            {

                XDocument doc = XDocument.Load("Tanár.xml");
                XElement tanár = new XElement("Tanár",
                    new XAttribute("Zeuszkód", újTanár.Zeuszkód),
                    new XElement("Név", újTanár.Név),
                    new XElement("Lakhely", újTanár.Lakhely),
                    new XElement("SzemélyIgazolványSzám", újTanár.SzemélyIgsz),
                    new XElement("SzületésiDátum", újTanár.SzületésiDátum),
                    new XElement("Születésihely", újTanár.SzületésiHely),
                    new XElement("Beosztás", újTanár.Beosztas));
                doc.Element("Tanárok").Add(tanár);
                doc.Save("Tanár.xml");

            }
            catch
            { }
        }
        //void tanárMódosítás(Tanár módosítottTanár,Tanár újTanár);
        //void tanárTörlés(string indoklás, Tanár tanár);
        //List<Tanár> tanárListázás();
        public void vezetőFelvétel(Vezető újVezető)
        {
            újVezető.Zeuszkód = generateZeuszKód();


            //xmlbe irat
            try
            {

                XDocument doc = XDocument.Load("Vezető.xml");
                XElement vezető = new XElement("Vezető",
                    new XAttribute("Zeuszkód", újVezető.Zeuszkód),
                    new XElement("Név", újVezető.Név),
                    new XElement("Lakhely", újVezető.Lakhely),
                    new XElement("SzemélyIgazolványSzám", újVezető.SzemélyIgsz),
                    new XElement("SzületésiDátum", újVezető.SzületésiDátum),
                    new XElement("Születésihely", újVezető.SzületésiHely));     
                doc.Element("Vezetők").Add(vezető);
                doc.Save("Vezető.xml");

            }
            catch
            { }
        }
        //void vezetőMódosítás(Vezető módosítottVezető, Vezető újVezető);
        //void vezetőTörlés(string indoklás, Vezető vezető);
        //List<Vezető> vezetőListázás();

    }
}
