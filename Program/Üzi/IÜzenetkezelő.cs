using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeusz;

namespace Zeusz {
	public interface IÜzenetkezelõ {

		void üzenetKiíratás(ref Üzenet üzenet);

		void üzenetküldés(Üzenet üzenet);

		List<Üzenet> üzenetListázás();
       
        void üzenetTörlés(Üzenet üzenet);
	}//end IÜzenetkezelõ

}//end namespace Zeusz