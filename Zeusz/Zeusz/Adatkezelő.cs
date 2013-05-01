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
        List<Tanár> beolvasottTanárok = new List<Tanár>();
        List<Vezető> beolvasottVezetők = new List<Vezető>();
    

       
        public void hallgatóFelvétel(Hallgató újHallgató)
        {
            if (újHallgató.Zeuszkód == null || újHallgató.Zeuszkód == "") //ha nem adunk meg kézzel generálok egyet hasraütésre
            {
                újHallgató.Zeuszkód = generateZeuszKód();
            }


            //xmlbe irat
            try
            {
                //ha nincs még file létrehozzuk
                if(!File.Exists("Hallgató.xml"))
                {
                    XElement hallgatók = new XElement("Hallgatók");
                    hallgatók.Save("Hallgató.xml");
                }
                
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
            
            HallgatóBeolvasás();
           // bool siker = false;
            try
            {
                foreach (Hallgató h in beolvasotthallgatók)
                {
                    if (h.Zeuszkód == módosítandóHallgató.Zeuszkód)
                    {
                        h.setÖsszesadat("", módosítottHallgató.Név, módosítottHallgató.Lakhely, módosítottHallgató.SzemélyIgsz, módosítottHallgató.SzületésiDátum, módosítottHallgató.SzületésiHely, módosítottHallgató.Aktiv, módosítottHallgató.Végzett);

                        XDocument doc = XDocument.Load("Hallgató.xml");
                        var hallgatók = from x in doc.Descendants("Hallgató")
                                    where x.Attribute("Zeuszkód").Value == módosítandóHallgató.Zeuszkód
                                    select x;
                        foreach (XElement hallgatóadat in hallgatók)
                        {
                            hallgatóadat.SetElementValue("Név", h.Név);
                            hallgatóadat.SetElementValue("Lakhely", h.Lakhely);
                            hallgatóadat.SetElementValue("SzemélyIgazolványSzám", h.SzemélyIgsz);
                            hallgatóadat.SetElementValue("SzületésiDátum", h.SzületésiDátum);
                            hallgatóadat.SetElementValue("Születésihely", h.SzületésiHely);
                            hallgatóadat.SetElementValue("FelvettTárgyak", h.FelvettTárgyak);
                            hallgatóadat.SetElementValue("Aktív", h.Aktiv);
                            hallgatóadat.SetElementValue("Végzett", h.Végzett);

                        }
                        doc.Save("Hallgató.xml");
             //           siker = true;

                    }
                }
                //if (siker = false) throw new Exception();

            }
            catch { }
        }
        public void hallgatóTörlés(string indoklás, Hallgató hallgató)
        {

            try
            {
                foreach (Hallgató h in beolvasotthallgatók)
                {
                    if (h.Zeuszkód == hallgató.Zeuszkód)
                    {
                        beolvasotthallgatók.Remove(h);

                        break;
                    }
                }
               
                
                //archiváljuk
                if (!File.Exists("ArchiveHallgató.xml"))
                {
                    XElement hallgatóarch = new XElement("Hallgatók");
                    hallgatóarch.Save("ArchiveHallgató.xml");
                }
              
                XDocument docarch = XDocument.Load("ArchiveHallgató.xml");
                XElement hallgatóarchive = new XElement("Hallgató",
                    new XAttribute("Zeuszkód", hallgató.Zeuszkód),
                    new XElement("Név", hallgató.Név),
                    new XElement("Lakhely", hallgató.Lakhely),
                    new XElement("SzemélyIgazolványSzám", hallgató.SzemélyIgsz),
                    new XElement("SzületésiDátum", hallgató.SzületésiDátum),
                    new XElement("Születésihely", hallgató.SzületésiHely),
                    new XElement("FelvettTárgyak", hallgató.FelvettTárgyak),
                    new XElement("Aktív", hallgató.Aktiv),
                    new XElement("Végzett", hallgató.Végzett),
                    new XElement("Indoklás", indoklás));
                docarch.Element("Hallgatók").Add(hallgatóarchive);
                docarch.Save("ArchiveHallgató.xml");

                //töröljük
                XDocument doc = XDocument.Load("Hallgató.xml");
                var hallgatók = from x in doc.Descendants("Hallgató")
                                where x.Attribute("Zeuszkód").Value == hallgató.Zeuszkód
                                select x;
                hallgatók.Remove();
                doc.Save("Hallgató.xml");
            }
            catch { }


        }

        public List<Hallgató> hallgatóListázás()    //done
        {
            beolvasotthallgatók.Clear();
            HallgatóBeolvasás();
            return beolvasotthallgatók;
        }


        public void passzívFélév(Hallgató hallgató)
        {
            HallgatóBeolvasás();
            // bool siker = false;
            try
            {
                foreach (Hallgató h in beolvasotthallgatók)
                {
                    if (h.Zeuszkód == hallgató.Zeuszkód)
                    {
                        h.setPassziv();

                        XDocument doc = XDocument.Load("Hallgató.xml");
                        var hallgatók = from x in doc.Descendants("Hallgató")
                                        where x.Attribute("Zeuszkód").Value == hallgató.Zeuszkód
                                        select x;
                        foreach (XElement hallgatóadat in hallgatók)
                        {
                            hallgatóadat.SetElementValue("Aktív", h.Aktiv);
                        }
                        doc.Save("Hallgató.xml");
                    }
                }
            }
            catch { }
        }

        public void tanárFelvétel(Tanár újTanár)
        {
            if (újTanár.Zeuszkód == null || újTanár.Zeuszkód == "")
            {
                újTanár.Zeuszkód = generateZeuszKód();
            }


            //xmlbe irat
            try
            {

                if (!File.Exists("Tanár.xml"))
                {
                    XElement hallgatók = new XElement("Tanárok");
                    hallgatók.Save("Tanár.xml");
                    
                }

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



       public void tanárMódosítás(Tanár módosítottTanár, Tanár újTanár)
        {
            TanárBeolvasás();
            //bool siker = false;
            try
            {
                foreach (Tanár t in beolvasottTanárok)
                {
                    if (t.Zeuszkód == újTanár.Zeuszkód)
                    {
                        t.setOsszesadat("", módosítottTanár.Név, módosítottTanár.Lakhely, módosítottTanár.SzemélyIgsz, módosítottTanár.SzületésiDátum, módosítottTanár.SzületésiHely, módosítottTanár.Beosztas);

                        XDocument doc = XDocument.Load("Tanár.xml");
                        var tanárok = from x in doc.Descendants("Tanár")
                                        where x.Attribute("Zeuszkód").Value == újTanár.Zeuszkód
                                        select x;
                        foreach (XElement tanáradat in tanárok)
                        {
                            tanáradat.SetElementValue("Név", t.Név);
                            tanáradat.SetElementValue("Lakhely", t.Lakhely);
                            tanáradat.SetElementValue("SzemélyIgazolványSzám", t.SzemélyIgsz);
                            tanáradat.SetElementValue("SzületésiDátum", t.SzületésiDátum);
                            tanáradat.SetElementValue("Születésihely", t.SzületésiHely);
                            tanáradat.SetElementValue("Beosztás", t.Beosztas);

                        }
                        doc.Save("Tanár.xml");
                       // siker = true;

                    }
                }
                //if (siker = false) throw new Exception();

            }
            catch { }
        }


       public void tanárTörlés(string indoklás, Tanár tanár)
       {

           try
           {
               foreach (Tanár t in beolvasottTanárok)
               {
                   if (t.Zeuszkód == tanár.Zeuszkód)
                   {
                       beolvasottTanárok.Remove(t);

                       break;
                   }
               }


               //archiváljuk
               if (!File.Exists("ArchiveTanár.xml"))
               {
                   XElement tanárarch = new XElement("Tanárok");
                   tanárarch.Save("ArchiveTanár.xml");
               }

               XDocument docarch = XDocument.Load("ArchiveTanár.xml");
               XElement tanárarchive = new XElement("Tanár",
                   new XAttribute("Zeuszkód", tanár.Zeuszkód),
                   new XElement("Név", tanár.Név),
                   new XElement("Lakhely", tanár.Lakhely),
                   new XElement("SzemélyIgazolványSzám", tanár.SzemélyIgsz),
                   new XElement("SzületésiDátum", tanár.SzületésiDátum),
                   new XElement("Születésihely", tanár.SzületésiHely),
                   new XElement("Beosztás", tanár.Beosztas),
                   new XElement("Indoklás", indoklás));
               docarch.Element("Tanárok").Add(tanárarchive);
               docarch.Save("ArchiveTanár.xml");

               //töröljük
               XDocument doc = XDocument.Load("Tanár.xml");
               var tanárok = from x in doc.Descendants("Tanár")
                               where x.Attribute("Zeuszkód").Value == tanár.Zeuszkód
                               select x;
               tanárok.Remove();
               doc.Save("Tanár.xml");
           }
           catch { }


       }
        
        
        public List<Tanár> tanárListázás()
        {
            beolvasottTanárok.Clear();
            TanárBeolvasás();
            return beolvasottTanárok;
        }
        public void vezetőFelvétel(Vezető újVezető)
        {
            if (újVezető.Zeuszkód == null || újVezető.Zeuszkód == "")
            {
                újVezető.Zeuszkód = generateZeuszKód();
            }

            //xmlbe irat
            try
            {

                if (!File.Exists("Vezető.xml"))
                {
                    XElement vezetők = new XElement("Vezetők");
                    vezetők.Save("Vezető.xml");
                }

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




        public void vezetőMódosítás(Vezető módosítottVezető, Vezető újVezető)
        {
            VezetőBeolvasás();
            //bool siker = false;
            try
            {
                foreach (Vezető v in beolvasottVezetők)
                {
                    if (v.Zeuszkód == újVezető.Zeuszkód)
                    {
                        v.setÖsszes("", módosítottVezető.Név, módosítottVezető.Lakhely, módosítottVezető.SzemélyIgsz, módosítottVezető.SzületésiDátum, módosítottVezető.SzületésiHely);

                        XDocument doc = XDocument.Load("Vezető.xml");
                        var vezetők = from x in doc.Descendants("Vezető")
                                      where x.Attribute("Zeuszkód").Value == újVezető.Zeuszkód
                                      select x;
                        foreach (XElement vezetőadat in vezetők)
                        {
                            vezetőadat.SetElementValue("Név", v.Név);
                            vezetőadat.SetElementValue("Lakhely", v.Lakhely);
                            vezetőadat.SetElementValue("SzemélyIgazolványSzám", v.SzemélyIgsz);
                            vezetőadat.SetElementValue("SzületésiDátum", v.SzületésiDátum);
                            vezetőadat.SetElementValue("Születésihely", v.SzületésiHely);


                        }
                        doc.Save("Tanár.xml");
                        // siker = true;

                    }
                }
                //if (siker = false) throw new Exception();

            }
            catch { }
        }


        public void vezetőTörlés(string indoklás, Vezető vezető)
        {

            try
            {
                foreach (Vezető v in beolvasottVezetők)
                {
                    if (v.Zeuszkód == vezető.Zeuszkód)
                    {
                        beolvasottVezetők.Remove(v);

                        break;
                    }
                }


                //archiváljuk
                if (!File.Exists("ArchiveVezető.xml"))
                {
                    XElement vezetőarch = new XElement("Vezetők");
                    vezetőarch.Save("ArchiveVezető.xml");
                }

                XDocument docarch = XDocument.Load("ArchiveVezető.xml");
                XElement vezetőarchive = new XElement("Vezető",
                    new XAttribute("Zeuszkód", vezető.Zeuszkód),
                    new XElement("Név", vezető.Név),
                    new XElement("Lakhely", vezető.Lakhely),
                    new XElement("SzemélyIgazolványSzám", vezető.SzemélyIgsz),
                    new XElement("SzületésiDátum", vezető.SzületésiDátum),
                    new XElement("Születésihely", vezető.SzületésiHely),
                    new XElement("Indoklás", indoklás));
                docarch.Element("Vezetők").Add(vezetőarchive);
                docarch.Save("ArchiveVezető.xml");

                //töröljük
                XDocument doc = XDocument.Load("Vezető.xml");
                var vezetők = from x in doc.Descendants("Vezető")
                              where x.Attribute("Zeuszkód").Value == vezető.Zeuszkód
                              select x;
                vezetők.Remove();
                doc.Save("Vezető.xml");
            }
            catch { }


        }


        public List<Vezető> vezetőListázás()
        {
            beolvasottVezetők.Clear();
            VezetőBeolvasás();
            return beolvasottVezetők;
        }




        // segédmetódusok

        private string generateZeuszKód()       // még ki kell egészíteni, hogy nézze a teljes listát, hgy lesz e egyezés, mert akkor újat kel generáltatni
        {
            string myZeusz = "";
            Random rnd = new Random(); //véletlen az ascii generáláshoz

            for (int i = 0; i < 6; i++)
            {
                int j=rnd.Next(0, 2);
                if (j == 0)
                {
                    myZeusz += rnd.Next(0, 9);
                }
                else
                {
                    myZeusz += Convert.ToChar(rnd.Next(65, 91));
                }
            }

            //check
            
            HallgatóBeolvasás();
            TanárBeolvasás();
            VezetőBeolvasás();

            foreach (Hallgató h in beolvasotthallgatók)
            {
                if (h.Zeuszkód == myZeusz)
                {
                    generateZeuszKód();
                }
            }
            foreach (Tanár t in beolvasottTanárok)
            {
                if (t.Zeuszkód == myZeusz)
                {
                    generateZeuszKód();
                }
            }
            foreach (Vezető v in beolvasottVezetők)
            {
                if (v.Zeuszkód == myZeusz)
                {
                    generateZeuszKód();
                }
            }
            return myZeusz;

        }

        private void HallgatóBeolvasás()
        {
            beolvasotthallgatók.Clear();
            try
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
            catch { }

        }

        private void TanárBeolvasás()
        {
            beolvasottTanárok.Clear();
            try
            {

                XDocument doc = XDocument.Load("Tanár.xml");

                foreach (var p in doc.Descendants("Tanár"))
                {
                    beolvasottTanárok.Add(new Tanár(


                         (string)p.Attribute("Zeuszkód"),
                         (string)p.Element("Név"),
                         (string)p.Element("Lakhely"),
                         (string)p.Element("SzemélyIgazolványSzám"),
                         (DateTime)p.Element("SzületésiDátum"),
                         (string)p.Element("Születésihely"),
                         (string)p.Element("Beosztás")));
                }
            }
            catch { }

        }
        private void VezetőBeolvasás()
        {
            beolvasottVezetők.Clear();
            try
            {

                XDocument doc = XDocument.Load("Vezető.xml");

                foreach (var p in doc.Descendants("Vezető"))
                {
                    beolvasottVezetők.Add(new Vezető(


                         (string)p.Attribute("Zeuszkód"),
                         (string)p.Element("Név"),
                         (string)p.Element("Lakhely"),
                         (string)p.Element("SzemélyIgazolványSzám"),
                         (DateTime)p.Element("SzületésiDátum"),
                         (string)p.Element("Születésihely")));
                }
            }
            catch { }

        }



    }
}
