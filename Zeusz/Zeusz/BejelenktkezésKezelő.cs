using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeusz
{
    class BejelenktkezésKezelő : IBejelenkezésKezelő
    {
        public void Beléptetés(string zeuszkód, string jelszó)
        {
            Adatkezelő adatKezelő = new Adatkezelő();
            Személy belep = new Személy("a","a","a",DateTime.Now,"a","a");
            List<Hallgató> hallgatók = adatKezelő.hallgatóListázás();
            List<Tanár> tanárok = adatKezelő.tanárListázás();
            List<Vezető> vezetők = adatKezelő.vezetőListázás();
            bool van = false;
            if (!van)
            {
                foreach (Hallgató h in hallgatók)
                {
                    if (h.Zeuszkód == zeuszkód)
                    {
                        belep = h;
                        van = true;
                        break;
                    }
                }
            }
            if (!van)
            {
                foreach (Tanár h in tanárok)
                {
                    if (h.Zeuszkód == zeuszkód)
                    {
                        belep = h;
                        van = true;
                        break;
                    }
                }
            }
            if (!van)
            {
                foreach (Vezető h in vezetők)
                {
                    if (h.Zeuszkód == zeuszkód)
                    {
                        belep = h;
                        van = true;
                        break;
                    }
                }
            }
            if (van)
            {
                if (belep is Hallgató)
                {
                    Hallgató_window hallgato_Form = new Hallgató_window((Hallgató)belep);
                    hallgato_Form.ShowDialog();
                }
                else
                {
                    if (belep is Tanár)
                    {
                        Tanár_window tanár_Form = new Tanár_window((Tanár)belep);
                        tanár_Form.ShowDialog();
                    }
                    else
                    {
                        if (belep is Vezető)
                        {
                            Vezető_window vezeto_Form = new Vezető_window((Vezető)belep);
                            vezeto_Form.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
