///////////////////////////////////////////////////////////
//  Tant�rgykezel�.cs
//  Implementation of the Class Tant�rgykezel�
//  Generated by Enterprise Architect
//  Created on:      25-�pr.-2013 0:43:00
//  Original author: Esse Zsolt
///////////////////////////////////////////////////////////



using System.Collections.Generic;
using Zeusz;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System;
namespace Zeusz {
	public class Tant�rgykezel� : ITant�rgykezel� {

		//public Szem�ly m_Szem�ly;
		//public Tant�rgy list_tant�rgyak;

        List<Tant�rgy> beolvasottTant�rgyak = new List<Tant�rgy>();

        public List<Tant�rgy> BeolvasottTant�rgyak
        {
            get { return beolvasottTant�rgyak; }
            set { beolvasottTant�rgyak = value; }
        }

        //konstruktor
		public Tant�rgykezel�(){}

        //met�dusok
        private  void tant�rgyBeolvas�s()
        {
             beolvasottTant�rgyak.Clear();
            try
            {

                if (File.Exists("Tant�rgy.xml"))
                {
                    XDocument doc = XDocument.Load("Tant�rgy.xml");



                    foreach (var p in doc.Descendants("Tant�rgy"))
                    {
                        int oktat�kSz�ma = ((string)p.Element("Oktat�k")).Length / 6;
                        string[] strOktT�mb = new string[oktat�kSz�ma];
                        for (int i = 0; i < oktat�kSz�ma; i++)
                        {
                            strOktT�mb[i] =
                                ((string)p.Element("Oktat�k")).Substring(i * 6, 6);
                        }

                        beolvasottTant�rgyak.Add(new Tant�rgy(
                             (string)p.Element("T�rgyn�v"),
                             (string)p.Attribute("t�rgyk�d"),
                             (string)p.Element("Helysz�n"),
                             (DateTime)p.Element("Kezd�s"),
                             (DateTime)p.Element("V�ge"),
                             (string)p.Element("H�t"),
                             strOktT�mb,
                             (string)p.Element("K�vetelm�nyek"),
                             (string)p.Element("Seg�dletek"))
                             );
                    }
                } //if file exists
            }
            catch (Exception e) { throw (e); }

        }
        
        
		//~Tant�rgykezel�(){}

		//public virtual void Dispose(){}


        void XMLL�trehoz�s_Tant�rgy(){
            try
            {
                if (!File.Exists("Tant�rgy.xml"))
                {

                    XElement tant�rgyak = new XElement("Tant�rgyak");
                    tant�rgyak.Save("Tant�rgy.xml");
                   
                }
            }
            catch (Exception e)
            { throw e; }
        }
        


		/// 
		/// <param name="tant�rgy"></param>
        public void T�rgyfelv�tel(Tant�rgy tant�rgy, string hallgat�Zeuszk�d)
        {
            try
            {

                if (File.Exists("Hallgat�.xml"))
                {
                    XDocument doc = XDocument.Load("Hallgat�.xml");


                    XElement tant�rgyElem = new XElement("FelvettTant�rgy",
                        new XAttribute("t�rgyk�d", tant�rgy.T�rgyk�d),
                        new XElement("T�rgyn�v", tant�rgy.T�rgyn�v),
                        new XElement("Helysz�n", tant�rgy.Helysz�n),
                        new XElement("Kezd�s", tant�rgy.Kezd�sId�pont.ToString()),
                        new XElement("V�ge", tant�rgy.V�geId�pont.ToString()),
                        new XElement("H�t", tant�rgy.H�t),
                        new XElement("Oktat�k", tant�rgy.Oktat�k),
                        new XElement("K�vetelm�nyek", tant�rgy.K�vetelm�nyek),
                        new XElement("Seg�dletek", tant�rgy.Seg�dletek));
                    doc.Element("FelvettT�rgyak").Add(tant�rgyElem);

                    doc.Save("Hallgat�.xml");

                } //if file exists
            }
            catch (Exception e) { throw (e); }
		}

		/// 
		/// <param name="tant�rgy"></param>
		public void T�rgylead�s(Tant�rgy tant�rgy, string hallgat�Zeuszk�d){

            try
            {

                if (File.Exists("Hallgat�.xml"))
                {
                    //XDocument doc = XDocument.Load("Hallgat�.xml");
                    //var t�rlend�T�rgy = doc.Root.Elements("Hallgat�")
                    //    .Where(c => c.Elements("Hallgat�")
                    //        .Where(d => d.Attribute("Zeuszk�d").Value == hallgat�Zeuszk�d)
                    //            .Where(e => e.Elements("FelvettT�rgyak")
                    //                .Where(f => f.Elements("FelvettTant�rgy")
                    //                    .Where(g => g.Attribute("t�rgyk�d").Value == tant�rgy.T�rgyk�d)
                    //t�rlend�T�rgy.Remove();
                    //doc.Save("Hallgat�.xml");

                } //if file exists
            }
            catch (Exception e) { throw (e); }
            throw new System.NotImplementedException();
		}

		/// 
		/// <param name="tant�rgy"></param>
		public void T�rgyhozz�ad�s(Tant�rgy tant�rgy){

            XMLL�trehoz�s_Tant�rgy();

            XDocument doc = XDocument.Load("Tant�rgy.xml");

            XElement tant�rgyElem = new XElement("Tant�rgy",
                new XAttribute("t�rgyk�d", tant�rgy.T�rgyk�d),
                new XElement("T�rgyn�v", tant�rgy.T�rgyn�v),
                new XElement("Helysz�n", tant�rgy.Helysz�n),
                new XElement("Kezd�s", tant�rgy.Kezd�sId�pont.ToString()),
                new XElement("V�ge", tant�rgy.V�geId�pont.ToString()),
                new XElement("H�t", tant�rgy.H�t),
                new XElement("Oktat�k", tant�rgy.Oktat�k),
                new XElement("K�vetelm�nyek", tant�rgy.K�vetelm�nyek),
                new XElement("Seg�dletek", tant�rgy.Seg�dletek));
            doc.Element("Tant�rgyak").Add(tant�rgyElem);

            doc.Save("Tant�rgy.xml");
		}

		/// 
		/// <param name="t�rgyr�l"></param>
		/// <param name="t�rgyra"></param>
		public void T�rgym�dos�t�s(string t�rgyr�l, Tant�rgy t�rgyra){
            throw new System.NotImplementedException();
		}

		/// 
		/// <param name="tant�rgy"></param>
		public void T�rgyt�rl�s(Tant�rgy tant�rgy){
            try
            {
                if (File.Exists("Tant�rgy.xml"))
                {
                    XDocument doc = XDocument.Load("Tant�rgy.xml");
                    var t = from tt in doc.Descendants("Tant�rgy")
                            where tt.Attribute("t�rgyk�d").Value == tant�rgy.T�rgyk�d
                            select tt;

                    //kit�r�lni tt-t
                    t.Remove();
                }
            }
            catch (Exception e)
            {

                throw (e);
            }
		}



		/// 
		/// <param name="tant�rgyak"></param>
		public List<Tant�rgy> tant�rgyList�z�s(){
            beolvasottTant�rgyak.Clear();
            tant�rgyBeolvas�s();
          return beolvasottTant�rgyak;
		}

        public List<Tant�rgy> tant�rgyList�z�s(string tan�rZeuszk�d)
        {
            beolvasottTant�rgyak.Clear();
            tant�rgyBeolvas�s();
            List<Tant�rgy> tant�rgyLista = new List<Tant�rgy>();
            foreach (var t�rgy in beolvasottTant�rgyak)
            {
                if(t�rgy.Oktat�k.Contains(tan�rZeuszk�d))
                    tant�rgyLista.Add(t�rgy);
            }
            return tant�rgyLista;
        }


        public void T�rgym�dos�t�s(Tant�rgy t�rgyr�l, Tant�rgy t�rgyra)
        {
            throw new System.NotImplementedException();
        }
    }//end Tant�rgykezel�

}//end namespace Zeusz