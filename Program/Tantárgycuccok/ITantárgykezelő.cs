///////////////////////////////////////////////////////////
//  ITant�rgykezel�.cs
//  Implementation of the Interface ITant�rgykezel�
//  Generated by Enterprise Architect
//  Original author: Esse Zsolt
///////////////////////////////////////////////////////////



using System.Collections.Generic;
using Zeusz;
namespace Zeusz {
	public interface ITant�rgykezel� {

		/// 
		/// <param name="tant�rgy"></param>
		void T�gyfelv�tel(Tant�rgy tant�rgy);

		/// 
		/// <param name="tant�rgy"></param>
		void T�rgylead�s(Tant�rgy tant�rgy);

		/// 
		/// <param name="tant�rgy"></param>
		void T�rgyhozz�ad�s(Tant�rgy tant�rgy);

		/// 
		/// <param name="t�rgyr�l"></param>
		/// <param name="t�rgyra"></param>
		void T�rgym�dos�t�s(Tant�rgy t�rgyr�l, Tant�rgy t�rgyra);

		/// 
		/// <param name="tant�rgy"></param>
		void T�rgyt�rl�s(Tant�rgy tant�rgy);

		/// 
		/// <param name="tant�rgyak"></param>
		List<Tant�rgy> tant�rgyList�z�s();
	}//end ITant�rgykezel�

}//end namespace Zeusz