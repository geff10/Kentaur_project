///////////////////////////////////////////////////////////
//  Tant�rgy.cs
//  Implementation of the Class Tant�rgy
//  Generated by Enterprise Architect
//  Original author: Esse Zsolt
///////////////////////////////////////////////////////////




using System;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Linq;
namespace Zeusz {
	public class Tant�rgy {
        public static Random R = new Random();
        private string t�rgyn�v;

        public string T�rgyn�v
        {
            get { return t�rgyn�v; }
            set { t�rgyn�v = value; }
        }
        private string t�rgyk�d;

        public string T�rgyk�d
        {
            get { return t�rgyk�d; }
            set { t�rgyk�d = value; }
        }
        private string helysz�n;

        public string Helysz�n
        {
            get { return helysz�n; }
            set { helysz�n = value; }
        }
        private DateTime v�geId�pont;

        public DateTime V�geId�pont
        {
            get { return v�geId�pont; }
            set { v�geId�pont = value; }
        }
		/// <summary>
		/// �ra + nap(ez megadhat�?)
		/// </summary>
        private DateTime kezd�sId�pont;

        public DateTime Kezd�sId�pont
        {
            get { return kezd�sId�pont; }
            set { kezd�sId�pont = value; }
        }
		/// <summary>
		/// p�ros/p�ratlan/minden h�t
		/// </summary>
        private string h�t;

        public string H�t
        {
            get { return h�t; }
            set { h�t = value; }
        }
        private string[] oktat�k;

        public string[] Oktat�k
        {
            get { return oktat�k; }
            set { oktat�k = value; }
        }

        private string k�vetelm�nyek;

        public string K�vetelm�nyek
        {
            get { return k�vetelm�nyek; }
            set { k�vetelm�nyek = value; }
        }
        private string seg�dletek;

        public string Seg�dletek
        {
            get { return seg�dletek; }
            set { seg�dletek = value; }
        }

        int kezd�s�ra;

        public int Kezd�s�ra
        {
            get { return kezd�s�ra; }
            set { kezd�s�ra = value; }
        }

        int kezd�sPerc;

        public int Kezd�sPerc
        {
            get { return kezd�sPerc; }
            set { kezd�sPerc = value; }
        }

        int v�ge�ra;

        public int V�ge�ra
        {
            get { return v�ge�ra; }
            set { v�ge�ra = value; }
        }

        int v�gePerc;

        public int V�gePerc
        {
            get { return v�gePerc; }
            set { v�gePerc = value; }
        }

        string h�tnapja;

        public string H�tnapja
        {
            get { return h�tnapja; }
            set { h�tnapja = value; }
        } 


        //met�dusok
        public string T�rgyK�dGen()
        {
            //beolvas
            //pszeudorandom
            string str = this.t�rgyn�v[0].ToString() +
                this.oktat�k[0][0].ToString() +
                this.kezd�sId�pont.ToString()[0].ToString() +
                this.h�t[this.h�t.Length-1] + R.Next(0, 9).ToString() +
                ((char)R.Next(65, 90)).ToString();
            return str;
        }



        //konstruktor
		public Tant�rgy(){
            
		}

        public Tant�rgy(string t�rgyn�v, string t�rgyk�d, string helysz�n,DateTime kezd�s,
            DateTime v�ge, string h�t, string[] oktat�k, string k�vetelm�nyek, string seg�dletek)
        {
            this.t�rgyn�v = t�rgyn�v;
            this.t�rgyk�d = t�rgyk�d;
            this.helysz�n = helysz�n;
            this.kezd�sId�pont = kezd�s;
            this.v�geId�pont = v�ge;
            this.h�t = h�t;
            this.oktat�k = oktat�k;
            this.k�vetelm�nyek = k�vetelm�nyek;
            this.seg�dletek = seg�dletek;

            this.kezd�s�ra = kezd�s.Hour;
            this.kezd�sPerc = kezd�s.Minute;
            this.v�ge�ra = v�ge.Hour;
            this.v�gePerc = v�ge.Minute;

            switch (kezd�sId�pont.DayOfWeek)
            {
                case DayOfWeek.Monday: { this.h�tnapja = "H�tf�"; break; }
                case DayOfWeek.Tuesday: { this.h�tnapja = "Kedd"; break; }
                case DayOfWeek.Wednesday: { this.h�tnapja = "Szerda"; break; }
                case DayOfWeek.Thursday: { this.h�tnapja = "Cs�t�rt�k"; break; }
                case DayOfWeek.Friday: { this.h�tnapja = "P�ntek"; break; }
                default:
                    this.h�tnapja = "H�tf�";
                    break;
            }
        }


        //t�rgyk�d n�lk�li
        public Tant�rgy(string t�rgyn�v,  string helysz�n, DateTime kezd�s,
                DateTime v�ge, string h�t, string[] oktat�k, string k�vetelm�nyek, string seg�dletek)
        {
            this.t�rgyn�v = t�rgyn�v;
            this.helysz�n = helysz�n;
            this.kezd�sId�pont = kezd�s;
            this.v�geId�pont = v�ge;
            this.h�t = h�t;
            this.oktat�k = oktat�k;
            this.k�vetelm�nyek = k�vetelm�nyek;
            this.seg�dletek = seg�dletek;

            this.kezd�s�ra = kezd�s.Hour;
            this.kezd�sPerc = kezd�s.Minute;
            this.v�ge�ra = v�ge.Hour;
            this.v�gePerc = v�ge.Minute;

            switch (kezd�sId�pont.DayOfWeek)
            {
                case DayOfWeek.Monday: { this.h�tnapja = "H�tf�"; break; }
                case DayOfWeek.Tuesday: { this.h�tnapja = "Kedd"; break; }
                case DayOfWeek.Wednesday: { this.h�tnapja = "Szerda"; break; }
                case DayOfWeek.Thursday: { this.h�tnapja = "Cs�t�rt�k"; break; }
                case DayOfWeek.Friday: { this.h�tnapja = "P�ntek"; break; }
                default:
                    this.h�tnapja = "H�tf�";
                    break;
            }

            bool foglalt = false;
            do {
                
                this.t�rgyk�d = T�rgyK�dGen();               
                try
                {
                    if (File.Exists("Tant�rgy.xml"))
                    {
                        
                        //XDocument doc = XDocument.Load("Tant�rgy.xml");
                        //var t = from tt in doc.Descendants("Tant�rgy")
                        //        where tt.Attribute("t�rgyk�d").Value == this.t�rgyk�d
                        //        select tt;
                        //if (t == null || t.First() == null ||
                        //    t.Count() == 0 ||
                        //    t.First().Attribute("t�rgyk�d").Value.Length < 5)
                        //    foglalt = false;
                        //else
                        //    foglalt = true;
                    }
                }
                catch (Exception e)
                {

                    throw (e);
                }
            } while(foglalt);
        }


        //egyszer�s�tett bevitel
        //t�rgyk�d n�lk�li
        public Tant�rgy(string t�rgyn�v, string helysz�n, int kezd�s�ra, int kezd�sPerc,int v�ge�ra, int v�gePerc,
            string h�tnapja, string h�t, string[] oktat�k, string k�vetelm�nyek, string seg�dletek)
        {
            this.t�rgyn�v = t�rgyn�v;
            this.helysz�n = helysz�n;

            int napEltol�s = 0;
            switch (h�tnapja)
            {
                case "H�tf�": { napEltol�s = 0; break; }
                case "Kedd": { napEltol�s = 1; break; }
                case "Szerda": { napEltol�s = 2; break; }
                case "Cs�t�rt�k": { napEltol�s = 3; break; }
                case "P�ntek": { napEltol�s = 4; break; }
                default:
                    napEltol�s = 0;
                    break;
            }
            //alap�rtelmezett d�tum legyen: 2013.5.13, H�tf�
            this.kezd�sId�pont = new DateTime(2013, 5, 13 + napEltol�s, kezd�s�ra, kezd�sPerc, 0);
            this.v�geId�pont = new DateTime(2013, 5, 13 + napEltol�s, v�ge�ra, v�gePerc, 0);
            this.kezd�s�ra = kezd�s�ra;
            this.kezd�sPerc = kezd�sPerc;
            this.v�ge�ra = v�ge�ra;
            this.v�gePerc = v�gePerc;
            this.h�tnapja = h�tnapja;
            this.h�t = h�t;
            this.oktat�k = oktat�k;
            this.k�vetelm�nyek = k�vetelm�nyek;
            this.seg�dletek = seg�dletek;

            bool foglalt = false;
            do
            {
                this.t�rgyk�d = T�rgyK�dGen();
                try
                {
                    if (File.Exists("Tant�rgy.xml"))
                    {
                        
                        //XDocument doc = XDocument.Load("Tant�rgy.xml");
                        //var t = from tt in doc.Descendants("Tant�rgy")
                        //        where tt.Attribute("t�rgyk�d").Value == this.t�rgyk�d
                        //        select tt;
                        //if (t == null || t.First() == null ||
                        //    t.Count() == 0 ||
                        //    t.First().Attribute("t�rgyk�d").Value.Length < 5)
                        //    foglalt = false;
                        //else
                        //    foglalt = true;
                    }
                }
                catch (Exception e)
                {

                    throw (e);
                }
            } while (foglalt);
        }
        

        /// <summary>
        /// ToString()-ek
        /// </summary>
        /// <returns></returns>


        public override string ToString()
        {
            return this.T�rgyn�v + "\n"
                + this.kezd�sId�pont.Hour.ToString() + ":" + this.kezd�sId�pont.Minute.ToString() + " - " +
                    this.v�geId�pont.Hour.ToString() + ":" + this.v�geId�pont.Minute.ToString() + "\n " +
                    this.h�tnapja + "\n" +
                    this.h�t + "\n" +
                    this.helysz�n + "\n" +
                    this.oktat�k + "\n" +
                    this.t�rgyk�d;

        }

        public string ToStringTeljes()
        {
            return this.T�rgyn�v + "\n"
            + this.kezd�sId�pont.Hour.ToString() + ":" + this.kezd�sId�pont.Minute.ToString() + " - " +
            this.v�geId�pont.Hour.ToString() + ":" + this.v�geId�pont.Minute.ToString() + "\n " +
            this.h�tnapja + "\n" +
            this.h�t + "\n" +
            this.helysz�n + "\n" +
            this.oktat�k + "\n" +
            this.t�rgyk�d + "\n" +
            this.k�vetelm�nyek + "\n" +
            this.seg�dletek;
        }


		//public virtual void Dispose(){}

	}//end Tant�rgy

}//end namespace Zeusz