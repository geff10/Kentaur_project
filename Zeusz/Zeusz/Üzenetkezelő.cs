using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeusz;

namespace Zeusz 
{
	public class Üzenetkezelõ : IÜzenetkezelõ 
    {

        public void üzenetKiíratás(Üzenet üzenet)
        {

            /* Üzenetazonosító.ToString() + " ; " + 
                     Címzettek.ToString() + " ; " + 
                        Feladó.ToString() + " ; " + 
                     Elolvasva.ToString() + " ; " + 
                  KüldésDátuma.ToString() + " ; " + 
                         Tárgy.ToString() + " ; "  + 
                 ÜzenetSzövege.ToString() + " ; ";
             */

            string újÜzenet = üzenet.getÖsszesAdat();
            string seged = null;
            int db;
            for (int i = 0; i < újÜzenet.Length; i++)
            {
                db = 0;
                if (újÜzenet[i] == ';')
                {
                    db++;
                    switch (db)
                    {
                        case '1':
                            {
                                //Üzenetazonosító
                                break;
                            }
                        case '2':
                            {
                                //Címzettek
                                break;
                            }
                        case '3':
                            {
                                //Feladó
                                break;
                            }
                        case '4':
                            {
                                //Elolvasva
                                break;
                            }
                        case '5':
                            {
                                // KüldésDátuma
                                break;
                            }
                        case '6':
                            {
                                //Tárgy
                                break;
                            }
                        case '7':
                            {
                                //ÜzenetSzövege
                                break;
                            }
                    }
                }
                else
                {
                    seged = seged + újÜzenet[i];
                }
            }
        }
		
        public void üzenetKüldés()
        {
            //Üzenet üzenet = new Üzenet(/*beolv üzik*/);
		}
		
        public List<Üzenet> üzenetListázás()
        {
            List<Üzenet> üzenetek = new List<Üzenet>();
            // Üzenet adatbázison végigmegyünk
            return üzenetek;
		}

		
        public void üzenetTörlés(Üzenet üzenet)
        {
            üzenet.delete();
		}

	}//end Üzenetkezelõ

}//end namespace Zeusz