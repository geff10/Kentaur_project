using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeusz;

namespace Zeusz {
	public interface I�zenetkezel� {

		void �zenetKi�rat�s(ref �zenet �zenet);

		void �zenetk�ld�s(�zenet �zenet);

		List<�zenet> �zenetList�z�s();
       
        void �zenetT�rl�s(�zenet �zenet);
	}//end I�zenetkezel�

}//end namespace Zeusz