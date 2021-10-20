using System;

namespace helloWorld
{
	public class Torre//:PiezaAjedrez
	{
		bool enroque;

		public Torre (bool enroque)//:base(mov,comidas,posX,posY,color)
		{

			this.enroque = enroque;
		}
			

		bool isTorre(){
			return enroque;
		}

		void setTorre(bool newTorre){
			enroque = newTorre;
		}

	}
}

