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




        //met�dusok
        public string T�rgyK�dGen()
        {
            //pszeudorandom
            string str = this.t�rgyn�v[0] + this.oktat�k[0][0] + this.kezd�sId�pont.ToString()[0] +
                this.h�t[this.h�t.Length-1] + R.Next(0, 9).ToString() + (char)R.Next(65, 90);
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

            bool foglalt = false;
            do {
                this.t�rgyk�d = T�rgyK�dGen();               
                try
                {
                    if (File.Exists("Tant�rgy.xml"))
                    {
                        XDocument doc = XDocument.Load("Tant�rgy.xml");
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

        

        /// <summary>
        /// ToString()-ek
        /// </summary>
        /// <returns></returns>


        public override string ToString()
        {
            return this.T�rgyn�v + "\n"
                + this.kezd�sId�pont.Hour.ToString() + ":" + this.kezd�sId�pont.Minute.ToString() + " - " +
                    this.v�geId�pont.Hour.ToString() + ":" + this.v�geId�pont.Minute.ToString() + "\n " +
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