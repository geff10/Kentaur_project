using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeusz;

namespace Zeusz 
{
	public class �zenetkezel� : I�zenetkezel� 
    {

        public void �zenetKi�rat�s(�zenet �zenet)
        {

            /* �zenetazonos�t�.ToString() + " ; " + 
                     C�mzettek.ToString() + " ; " + 
                        Felad�.ToString() + " ; " + 
                     Elolvasva.ToString() + " ; " + 
                  K�ld�sD�tuma.ToString() + " ; " + 
                         T�rgy.ToString() + " ; "  + 
                 �zenetSz�vege.ToString() + " ; ";
             */

            string �j�zenet = �zenet.get�sszesAdat();
            string seged = null;
            int db;
            for (int i = 0; i < �j�zenet.Length; i++)
            {
                db = 0;
                if (�j�zenet[i] == ';')
                {
                    db++;
                    switch (db)
                    {
                        case '1':
                            {
                                //�zenetazonos�t�
                                break;
                            }
                        case '2':
                            {
                                //C�mzettek
                                break;
                            }
                        case '3':
                            {
                                //Felad�
                                break;
                            }
                        case '4':
                            {
                                //Elolvasva
                                break;
                            }
                        case '5':
                            {
                                // K�ld�sD�tuma
                                break;
                            }
                        case '6':
                            {
                                //T�rgy
                                break;
                            }
                        case '7':
                            {
                                //�zenetSz�vege
                                break;
                            }
                    }
                }
                else
                {
                    seged = seged + �j�zenet[i];
                }
            }
        }
		
        public void �zenetK�ld�s()
        {
            //�zenet �zenet = new �zenet(/*beolv �zik*/);
		}
		
        public List<�zenet> �zenetList�z�s()
        {
            List<�zenet> �zenetek = new List<�zenet>();
            // �zenet adatb�zison v�gigmegy�nk
            return �zenetek;
		}

		
        public void �zenetT�rl�s(�zenet �zenet)
        {
            �zenet.delete();
		}

	}//end �zenetkezel�

}//end namespace Zeusz